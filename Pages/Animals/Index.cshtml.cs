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
    public class IndexModel : PageModel
    {
        private readonly Final.Models.ShelterDbContext _context;

        public IndexModel(Final.Models.ShelterDbContext context)
        {
            _context = context;
        }

        public IList<Animal> Animal { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Animals != null)
            {
                Animal = await _context.Animals
                .Include(a => a.Shelter).ToListAsync();
            }
        }
    }
}
