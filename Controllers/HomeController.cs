using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    ApplicationDbContext _context;
   
    public HomeController(ApplicationDbContext context,ILogger<HomeController> logger)
    {
        _logger = logger;
        _context = context;

    }
   
    public IActionResult Index() => View();
    public IActionResult About() => View();    
    public IActionResult Contact() => View();
    public IActionResult Privacy() => View();   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
