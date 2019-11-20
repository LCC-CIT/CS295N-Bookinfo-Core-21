﻿using GoodBookNook.Models;
using System;
using System.Collections.Generic;

namespace GoodBookNook.Repositories
{
    public  class FakeBookRepository : IBookRepository
    {
        private  List<Book> books = new List<Book>();
        public  List<Book> Books { get { return books; } }

         public FakeBookRepository()
        {
            AddTestData();
        }

        public  void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddReview(Book book, Review review)
        {
            //TODO finish this method
        }
        public  Book GetBookByTitle(string title)
        {
            Book book = books.Find(b => b.Title == title);
            return book;
        }

        void AddTestData()
        {
            Book book = new Book()
            {
                Title = "The Fellowship of the Ring",
                PubDate = new DateTime(1937, 1, 1)
            };
            book.Authors.Add(new Author
            {
                Name = "J.R.R. Tolkein"
            }
            );
            books.Add(book);

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
            books.Add(book);

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
            books.Add(book);
        }
    }
}