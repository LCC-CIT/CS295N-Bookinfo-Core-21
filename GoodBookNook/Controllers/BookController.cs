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

            book = new Book()
            {
                Title = "The Fellowship of the Ring",
                PubDate = new DateTime(1937, 1, 1)
            };
            book.Authors.Add(new Author {
                Name = "J.R.R. Tolkein" }
            );
            BookRepository.AddBook(book);
        }

        public IActionResult Index()
        {
            return View(BookRepository.Books);
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddBook(string title,
                                              string author,string pubDate)
        {
            book = new Book();
            book.Title = title;
            book.Authors.Add(new Author() { Name = author });
            book.PubDate = DateTime.Parse(pubDate);
            return RedirectToAction("Index");
        }
    }
}