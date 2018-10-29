using GoodBookNook.Controllers;
using GoodBookNook.Models;
using Xunit;

namespace GoodBookNook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var bookController = new BookController();

            // Act
            bookController.AddBook("A Tale of Two Cities",
                "Charles Dickens", "1/1/1859");
            // Assert
            Assert.Equal("A Tale of Two Cities",
                BookRepository.Books[BookRepository.Books.Count - 1].Title);
        }
    }
}
