using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnimationCharacters.Models;

namespace AnimationCharacters.Pages_AnimationCharacter
{
    public class EditModel : PageModel
    {
        private readonly AnimationCharactersContext _context;

        public EditModel(AnimationCharactersContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AnimationCharacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimationCharacterExists(AnimationCharacter.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AnimationCharacterExists(int id)
        {
            return _context.AnimationCharacter.Any(e => e.ID == id);
        }
    }
}
