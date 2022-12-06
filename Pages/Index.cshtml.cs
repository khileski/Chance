using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace Chance.Pages;

public class IndexModel : PageModel
{
    private readonly ShelterDbContext _context;
    private readonly ILogger<IndexModel> _logger;
    

    public IndexModel(ShelterDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}
