using buoi6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace buoi6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(HttpContext.Request.Cookies.ContainsKey("AccountFullname"))
            {
                ViewBag.AccountUsername = HttpContext.Request.Cookies["AccountFullname"].ToString();
            }    
            return View();
        }
        public IActionResult Index_Customer()
        {
            if (HttpContext.Request.Cookies.ContainsKey("AccountFullname"))
            {
                ViewBag.AccountUsername = HttpContext.Request.Cookies["AccountFullname"].ToString();
            }
            return View();
        }
        public IActionResult Index_Customer_ID()
        {
            if (HttpContext.Request.Cookies.ContainsKey("AccountID"))
            {
                ViewBag.Account_Id = HttpContext.Request.Cookies["AccountID"].ToString();
            }
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
}
