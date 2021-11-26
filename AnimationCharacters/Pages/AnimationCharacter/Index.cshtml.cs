using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AnimationCharacters.Models;

namespace AnimationCharacters.Pages_AnimationCharacter
{
    public class IndexModel : PageModel
    {
        private readonly AnimationCharactersContext _context;

        public IndexModel(AnimationCharactersContext context)
        {
            _context = context;
        }

        public IList<AnimationCharacter> AnimationCharacter { get;set; }

        public async Task OnGetAsync()
        {
            AnimationCharacter = await _context.AnimationCharacter.ToListAsync();
        }
    }
}
