using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IList<Character> Character { get;set; }

        public async Task OnGetAsync()
        {
            Character = await _context.Character.ToListAsync();
        }
    }
}
