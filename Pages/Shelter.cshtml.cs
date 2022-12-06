using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Chance.Pages;

public class ShelterModel : PageModel
{
    private readonly ShelterDbContext _context;
    private readonly ILogger<ShelterModel> _logger;
    public List<Shelter>Shelters {get;set;} = default!;
    public SelectList SheltersDrop {get;set;} = default!;

    [BindProperty]
    public Shelter Shelter {get;set;} = default!;

    public ShelterModel(ShelterDbContext context, ILogger<ShelterModel> logger)
    {
        _context = context;
        _logger = logger;
    }
    public void OnGet()
    {
        Shelters = _context.Shelters.ToList();
        SheltersDrop = new SelectList(Shelters, "Name", "Address", "Town");
    }

    public void OnPost()
    {
        Shelter = _context.Shelters.Find(Shelter.ShelterId)!;
        Shelters = _context.Shelters.ToList();
        SheltersDrop = new SelectList(Shelters, "Name", "Address", "Town");
    }
}