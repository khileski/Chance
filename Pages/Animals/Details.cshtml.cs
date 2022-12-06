using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace Chance.Pages.Animals
{
    public class DetailsModel : PageModel
    {
        private readonly ShelterContext _context;

        public DetailsModel(ShelterContext context)
        {
            _context = context;
        }

      public Animal Animal { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Animal == null)
            {
                return NotFound();
            }

            var animal = await _context.Animal.FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animal == null)
            {
                return NotFound();
            }
            else 
            {
                Animal = animal;
            }
            return Page();
        }
    }
}
