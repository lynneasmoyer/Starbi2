using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Starbie.Models;

namespace Starbie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("About")]
        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet("Characters")]
        public IActionResult Characters()
        {
            return View();
        }

        [HttpGet("PlayGame")]
        public IActionResult PlayGame()
        {
            return View();
        }

















/////////////////////////////////////////////////////
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
}
