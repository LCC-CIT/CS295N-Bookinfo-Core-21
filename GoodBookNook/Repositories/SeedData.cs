﻿using System;
using System.Linq;
using GoodBookNook.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GoodBookNook.Repositories
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();
            if (!context.Books.Any())
            {
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
                // author.Books.Add(book);
                book.Reviews.Add(review);
                context.Books.Add(book);

                context.SaveChanges(); // save all the data
            }
        }
    }
}
