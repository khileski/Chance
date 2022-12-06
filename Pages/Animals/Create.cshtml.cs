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
        private readonly Final.Models.ShelterDbContext _context;

        public CreateModel(Final.Models.ShelterDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ShelterId"] = new SelectList(_context.Shelters, "ShelterId", "ShelterId");
            return Page();
        }

        [BindProperty]
        public Animal Animal { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Animals == null || Animal == null)
            {
                return Page();
            }

            _context.Animals.Add(Animal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
