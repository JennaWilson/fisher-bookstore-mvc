using System;
using Microsoft.AspNetCore.Mvc;

namespace fisher.Bookstore.Controllers
{
    [Route("books")]
        public class BooksController : Controller
    {
        [Route("")] //handles the route '/books'
        [Route("index")] //handles the route '/books/index'
        public IActionResult Index()
        {
            return View();
            return Content("This is the Books controller's Index action");
        }
        [Route("new")]
        public IActionResult New()
        {
            return View();
            return Content("This is the Books controller's New action");
        }
        [Route("best-sellers")]
        public IActionResult Best()
        {
            return View();
            return Content("This is the Books controller's Best action");
        }
        }
    }
    