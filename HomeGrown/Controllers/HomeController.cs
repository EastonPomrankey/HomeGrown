using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeGrown.Models;
using HomeGrown.Data;

namespace HomeGrown.Controllers;

public class HomeController : Controller
{
    private readonly HomeGrownDbContext _context;

    public HomeController(HomeGrownDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
