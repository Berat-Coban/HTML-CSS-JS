using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Yeni_klasör.Models;
using Yeni_klasör.Models.Entites;

namespace Yeni_klasör.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    MydbContext db = new MydbContext();

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult contact()
    {
        return View();
    }

 public IActionResult TodoList()
    {
        var model = new TodoViewModel(){
            Todos=db.Todos.ToList(),
            };
        
        return View(model);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
