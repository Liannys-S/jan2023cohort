using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string message = "What's up, Doc?";
        return View("Index",message);
    }

    [HttpGet("/numbers")]
    public IActionResult Numbers(){
        int[] nums = new int[]{1,2,3,10,43,5};
        return View(nums); 
    }
    [HttpGet("/users")]
    public IActionResult Users(){
        List<string> users = new List<string>();
        users.Add("Moose Phillips");
        users.Add("Sarah");
        users.Add("Jerry");
        users.Add("Rene Ricky");
        users.Add("Barbara");
        return View(users);
    }
    [HttpGet("/user")]
        public IActionResult User(User user){
            user.Name = "Liannys";
            return View(user);
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
