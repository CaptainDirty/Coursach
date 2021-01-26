using Coursach.Models;
using MathLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Coursach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Index(Formulas input)
        {
            ViewData["input"] = input;
            ViewBag.Formulas = input;

            var Diagramm = new List<double>() { input.Re(), input.NuKor, input.NuShakh, input.a3r(input.NuKor), input.a3r(input.NuShakh) };//Выводим график
            ViewBag.TheDiagramm = Newtonsoft.Json.JsonConvert.SerializeObject(Diagramm);

            return View();
        }
            
        public IActionResult Index()
        {
            ViewData["input"] = new Formulas();

            return View();
        }
        public IActionResult Information()
        {
            return View();
        }
         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
