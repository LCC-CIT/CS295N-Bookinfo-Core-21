using System;
using System.Data;
using System.Linq;
using GoodBookNook.Controllers;
using GoodBookNook.Models;
using GoodBookNook.Repositories;
using Xunit;

namespace GoodBookNook.Tests
{
    public class BookTest
    {
        [Fact]
        public void AddBookTest()
        {
            // Arrange
            var repo = new FakeBookRepository();
            var bookController = new BookController(repo);

            // Act
            bookController.AddBook(new Book() {Title = "A Tale of Two Cities", PubDate = new DateTime(1859, 1, 1) },
                "Charles Dickens");

        // Assert
            Assert.Equal("A Tale of Two Cities",
                repo.Books.Last().Title);
        }

        [Fact]
        public void AddReviewTest()
        {
            // Arrange

            var repo = new FakeBookRepository();
            var bookController = new BookController(repo);

            // Act
            const string TITLE = "The Fellowship of the Ring";
            const string REVIEW = "This is a great classic!";
            bookController.AddReview(TITLE, REVIEW, "Brian");

            // Assert
            Book book = repo.GetBookByTitle(TITLE);
            Assert.Equal(REVIEW, book.Reviews.Last<Review>().ReviewText);
        }
    }
}
