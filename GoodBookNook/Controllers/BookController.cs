using System;
using System.Collections.Generic;
using GoodBookNook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using GoodBookNook.Repositories;
using System.Linq;

namespace GoodBookNook.Controllers
{
    public class BookController : Controller
    {
        IBookRepository repo;
        public BookController(IBookRepository r)
        {
            repo = r;
        }


        public IActionResult Index()
        {
            List<Book> books = repo.Books.ToList();
            books.Sort((b1, b2) => string.Compare(b1.Title, b2.Title, StringComparison.Ordinal));
            return View(books);
        }

        [HttpPost]
        public IActionResult Index(string title)
        {
            List<Book> books = (from b in repo.Books
                               where b.Title == title
                               select b).ToList();
            return View(books);
        }

        public IActionResult AddBook()
        {
            return View();
        }

        public IActionResult Authors()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddBook(Book book,
                                              string author)
        {
            if (ModelState.IsValid)
            {
                book.Authors.Add(new Author() { Name = author });
                repo.AddBook(book);  
            }
            return RedirectToAction("Index");
        }

        public IActionResult AddReview(string title)
        {
            return View("AddReview", HttpUtility.HtmlDecode(title));
        }

        [HttpPost]
        public RedirectToActionResult AddReview(string title, 
                                                string reviewText,
                                                string reviewer)
        {

            Book book = repo.GetBookByTitle(title);
            repo.AddReview(book,
                new Review() {
                Reviewer = new User() { Name = reviewer }, 
                ReviewText = reviewText });
            return RedirectToAction("Index");
        }


    }
}