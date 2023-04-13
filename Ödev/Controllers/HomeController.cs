using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ödev.Models;

namespace sport.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [Route("/About")]
    public IActionResult About()
    {
        return View();
    }
    [Route("/Services")]

    public IActionResult Services()
    {
        return View();
    }
    [Route("/Products")]

    public IActionResult Products()
    {
        return View();
    }
    [Route("/Rates")]

    public IActionResult Rates()
    {
        return View();
    }
    [Route("/Blog")]

    public IActionResult Blog()
    {
        return View();
    }
    [Route("/blog/{title}/{id}")]

    public IActionResult BlogSingle(String title, int id)
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
