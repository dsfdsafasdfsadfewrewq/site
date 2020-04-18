using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Сайт.Models;

namespace Сайт.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public List<ItemClass> items = new List<ItemClass>();

        public HomeController(ILogger<HomeController> logger)
        {
            items.Add(new ItemClass("LAMBORGHINI HURACAN EVO", "/img/HUracan-Evo-310x152.png", 1096, "Желтый / Синий"));
            items.Add(new ItemClass("Lamborghini Huracan Spyder LP 610", "/img/Spyder-310x121.png", 959, "Серебряный"));
            items.Add(new ItemClass("McLaren 650S", "/img/BS5B3720-copy-310x116.png", 767, "Черный / Белый"));
            items.Add(new ItemClass("Audi R8 Spyder", "/img/Audi-Spyder-1-310x116.png", 521, "Черный / Белый"));
            items.Add(new ItemClass("Ferrari Портофино Россо", "/img/Ferrari-Portofino-1-310x133.png", 1014, "Красный"));
            items.Add(new ItemClass("Mercedes GTS AMG", "/img/mercedes-gts-amg-310x135.png", 500, "Черный / Белый / Серый")); 
                   }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.items = items;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
