using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final.Models;

namespace Chance.Pages.Animals
{
    public class CreateModel : PageModel
    {
        private readonly ShelterContext _context;

        public CreateModel(ShelterContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ShelterId"] = new SelectList(_context.Set<Shelter>(), "ShelterId", "ShelterId");
            return Page();
        }

        [BindProperty]
        public Animal Animal { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Animal == null || Animal == null)
            {
                return Page();
            }

            _context.Animal.Add(Animal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
