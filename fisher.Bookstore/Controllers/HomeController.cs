using System;
using Microsoft.AspNetCore.Mvc;

namespace fisher.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            return Content("Hello World");
        }
    }
}