using System;
using System.Collections.Generic;
using GoodBookNook.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoodBookNook.Controllers
{
    public class BookController : Controller
    {
        Book book;
        public BookController()
        {
            // This is temporary code, just for testing
            if (BookRepository.Books.Count == 0)  // only do this if it hasn't been done already
            {
                book = new Book()
                {
                    Title = "The Fellowship of the Ring",
                    PubDate = new DateTime(1937, 1, 1)
                };
                book.Authors.Add(new Author
                {
                    Name = "J.R.R. Tolkein"
                }
                );
                BookRepository.AddBook(book);

                book = new Book()
                {
                    Title = "Book2",
                    PubDate = new DateTime(1970, 1, 1)
                };
                book.Authors.Add(new Author
                {
                    Name = "Author 2"
                }
                );
                Review review = new Review() { ReviewText = "Awesome book!" };
                book.Reviews.Add(review);
                BookRepository.AddBook(book);

                book = new Book()
                {
                    Title = "Another Book",
                    PubDate = new DateTime(2000, 1, 1)
                };
                book.Authors.Add(new Author
                {
                    Name = "Unknown"
                }
                );
                BookRepository.AddBook(book);
            }
        }

        public IActionResult Index()
        {
            List<Book> books = BookRepository.Books;
            books.Sort((b1,b2) => b1.Title.CompareTo(b2.Title));
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
        public RedirectToActionResult AddBook(string title,
                                              string author,string pubDate)
        {
            book = new Book();
            book.Title = title;
            book.Authors.Add(new Author() { Name = author });
            book.PubDate = DateTime.Parse(pubDate);
            BookRepository.AddBook(book);  // this is temporary, in the future the data will go in a database

            return RedirectToAction("Index");
        }
    }
}