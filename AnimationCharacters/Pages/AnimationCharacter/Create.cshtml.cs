using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AnimationCharacters.Models;

namespace AnimationCharacters.Pages_AnimationCharacter
{
    public class CreateModel : PageModel
    {
        private readonly AnimationCharactersContext _context;

        public CreateModel(AnimationCharactersContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AnimationCharacter AnimationCharacter { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AnimationCharacter.Add(AnimationCharacter);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
