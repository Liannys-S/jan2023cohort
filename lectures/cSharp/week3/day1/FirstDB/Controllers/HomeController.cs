<<<<<<< HEAD
﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstDB.Models;

namespace FirstDB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context; 

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context; 
    }

    public IActionResult Index()
    {
        List<Squishy> AllSquishys = _context.Squishys.ToList();
        return View();  
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
=======
﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstDB.Models;

namespace FirstDB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context; 

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context; 
    }

    public IActionResult Index()
    {
        List<Squishy> AllSquishys = _context.Squishys.ToList();
        return View();  
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
>>>>>>> 1def53ab125148c20df1151b159c23eec6daecf7
