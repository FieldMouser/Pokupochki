using Microsoft.AspNetCore.Mvc;
using Pokupochki.Data;
using Pokupochki.Models;

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
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Expence expence)
    {
        if (ModelState.IsValid)
        {
            _context.Expences.Add(expence);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        return View();
    }
}