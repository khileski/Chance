using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
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
        //search bar coding 
        [BindProperty(SupportsGet = true)]
        public string? SearchString {get;set;}
        public SelectList? Kind {get;set;}
        [BindProperty(SupportsGet = true)]
        public string? AnimalType {get;set;}
        // paging code
        [BindProperty(SupportsGet = true)]
        public int PageNum {get;set;} = 1;
        public int PageSize {get;set;} = 10;

        public async Task OnGetAsync()
        {
            
            var Animals = from a in _context.Animals
                select a;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Animals = Animals.Where(a => a.Type.Contains(SearchString));
            }
            Animal = await _context.Animals.Include(a => a.Shelter).Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            
            
        }
    }
}
