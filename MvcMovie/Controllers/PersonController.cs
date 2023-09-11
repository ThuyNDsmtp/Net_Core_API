using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using Microsoft.Extensions.Logging;

namespace MvcMovie.Controllers
{
    //[Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps){
            if(ModelState.IsValid)
            {
                 string strOutput = "Xin chào "+ps.PersonId+"-"+ps.FullName+"-"+ps.Address;
                ViewBag.infoPerson = strOutput;
            } else {
                ModelState.AddModelError("","Du lieu dau vao khong hop le");
            }
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}