using System;
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
            bookController.AddBook("A Tale of Two Cities",
                "Charles Dickens", "1/1/1859");

            // Assert
            Assert.Equal("A Tale of Two Cities",
                repo.Books[repo.Books.Count - 1].Title);
        }
    }
}
