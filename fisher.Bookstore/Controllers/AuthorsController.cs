using System;
using Microsoft.AspNetCore.Mvc;

namespace fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Authors controller's Index action");
        }
        public IActionResult Featured()
        {
            return Content("This is the Authors controller's Featured action");
        }
        }
    }