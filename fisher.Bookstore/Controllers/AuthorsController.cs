using System;
using fisher.Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
            return Content("This is the Authors controller's Index action");
        }
        public IActionResult Featured()
        {
            // would normally come from DB

            var featuredAuthor = new Author()
            {
                AuthorID = 1,
                
                Name = "J.K. Rowling" 
            };

            return View(featuredAuthor);
            }
        }
    }