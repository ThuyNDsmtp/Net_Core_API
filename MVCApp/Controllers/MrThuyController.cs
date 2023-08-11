using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers;

public class MrThuyController : Controller
{
    private readonly ILogger<MrThuyController> _logger;

    public MrThuyController(ILogger<MrThuyController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index(string fName, string address)
    {
        if(fName is null)
            ViewBag.ThongBao = "Nothing";
        else
            ViewBag.ThongBao = fName + " - " + address;
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