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
    public class DeleteModel : PageModel
    {
        private readonly AnimationCharactersContext _context;

        public DeleteModel(AnimationCharactersContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AnimationCharacter AnimationCharacter { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AnimationCharacter = await _context.AnimationCharacter.FirstOrDefaultAsync(m => m.ID == id);

            if (AnimationCharacter == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AnimationCharacter = await _context.AnimationCharacter.FindAsync(id);

            if (AnimationCharacter != null)
            {
                _context.AnimationCharacter.Remove(AnimationCharacter);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
