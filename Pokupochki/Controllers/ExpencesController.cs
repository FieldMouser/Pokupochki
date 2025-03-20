using Microsoft.AspNetCore.Mvc;
using Pokupochki.Data;

namespace Pokupochki.Controllers;

public class ExpencesController : Controller
{
    private readonly PokupochkiContext _context;

    public ExpencesController(PokupochkiContext context)
    {
        _context = context;
    }
    // GET
    public IActionResult Index()
    {
        var expenses = _context.Expences.ToList();
        return View(expenses);
    }
}