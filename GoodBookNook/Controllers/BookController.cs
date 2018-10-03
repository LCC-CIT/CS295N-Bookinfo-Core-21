using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodBookNook.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoodBookNook.Controllers
{
    public class BookController : Controller
    {
        Book book;
        public BookController()
        {
            /*
            book = new Book()
            {
                Title = "The Fellowship of the Ring",
                PubDate = new DateTime(1937, 1, 1)
            };
            book.Authors.Add(new Author {
                Name = "J.R.R. Tolkein" }
            );
            */
        }

        public IActionResult Index()
        {
            return View(book);
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddBook(string Title,
            string Author,string PubDate)
        {
            book = new Book();
            book.Title = Title;
            book.Authors.Add(new Author() { Name = Author });
            book.PubDate = DateTime.Parse(PubDate);
            return RedirectToAction("Index");
        }
    }
}