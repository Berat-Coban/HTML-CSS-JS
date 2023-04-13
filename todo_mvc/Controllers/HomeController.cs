using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.Models.Entities;

namespace TodoList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    MydbContext db = new MydbContext();
    [Route("/index")]
    public IActionResult Index()
    {
        return View();
    }
 [Route("/privcy")]
    public IActionResult Privacy()
    {
        return View();
    }
    [Route("/contract")]
     public IActionResult Contract()
    {
        return View();
    }
 [Route("/todolist")]
    public IActionResult TodoList()
    {
        var model= new TodoViewModel(){
            Todos=db.Todos.ToList(),
        };
        return View(model);
    }
    [HttpPost]
    [IgnoreAntiforgeryToken]
    [Route("/add-todo")]
     public IActionResult AddTodo(Todo postedData)
    {
         Todo toAdd = new Todo();
         toAdd.Title=postedData.Title;
         toAdd.IsComplated=false;
         db.Add(toAdd);
         db.SaveChanges();

        return Redirect("/todolist");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
