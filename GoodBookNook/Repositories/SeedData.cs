using GoodBookNook.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodBookNook.Repositories
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            if (!context.Books.Any())
            {
                // Book by Samuel Shellagarger
                Author author = new Author { Name = "Samuel Shellabarger" };
                context.Authors.Add(author);

                User user = new User { Name = "Walter Cronkite" };
                context.Users.Add(user);

                Review review = new Review
                {
                    ReviewText = "Great book, a must read!",
                    Reviewer = user
                };
                context.Reviews.Add(review);

                Book book = new Book
                {
                    Title = "Prince of Foxes",
                    PubDate = DateTime.Parse("1/1/1947")
                };
                book.Authors.Add(author);
                book.Reviews.Add(review);
                context.Books.Add(book);   // add the book to the dB Context

                // Books by J. R. R. Tolkien
                author = new Author { Name = "J. R. R. Tolkien" };
                context.Authors.Add(author);

                Book book1 = new Book { Title = "Fellowship of the Ring", PubDate = DateTime.Parse("7/24/1954") }; // month/day/year
                book1.Authors.Add(author);
                context.Books.Add(book1); 

                Book book2 = new Book { Title = "The Two Towers", PubDate = DateTime.Parse("1/1/1937") }; // month/day/year
                book2.Authors.Add(author);
                context.Books.Add(book2);   


                Book book3 = new Book { Title = "The Return of the King", PubDate = DateTime.Parse("1/1/1937") }; // month/day/year

                book3.Authors.Add(author); 
                context.Books.Add(book3);   
                // context.SaveChanges();      // save it so it gets an ID (PK value)

                context.SaveChanges(); // save all the data
            }
        }
    }
}
