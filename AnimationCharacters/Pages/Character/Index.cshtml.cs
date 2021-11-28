using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnimationCharacters.Models;
using AnimationCharacters.Data;

namespace AnimationCharacters.Pages_Character
{
    public class IndexModel : PageModel
    {
        private readonly AnimationCharactersContext _context;

        public IndexModel(AnimationCharactersContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Categories { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CtgCharacter { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of Categories.
            IQueryable<string> categoryQuery = from m in _context.Character orderby m.CategoryCharacter select m.CategoryCharacter;

            var characters = from m in _context.Character select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
               characters = characters.Where(s => s.TitleMovie.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CtgCharacter))
            {
                characters = characters.Where(x => x.CategoryCharacter == CtgCharacter);
            }

            Categories = new SelectList(await categoryQuery.Distinct().ToListAsync());
            Character = await characters.ToListAsync();
        }
    }
}
