using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Finals.Pages;

public class ShelterModel : PageModel
{
    private readonly ShelterDbContext _context;
    private readonly ILogger<ShelterModel> _logger;
    

    public ShelterModel(ShelterDbContext context, ILogger<ShelterModel> logger)
    {
        _context = context;
        _logger = logger;
    }
    public void OnGet()
    {
        
    }
}