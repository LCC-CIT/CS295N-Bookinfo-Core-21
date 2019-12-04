using GoodBookNook.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodBookNook.Repositories
{
    public class AppDbContext : DbContext
    {
        // This constructor will be called by the DI service set up in Startup
        public AppDbContext(
           DbContextOptions<AppDbContext> options) : base(options) { }
        
        // This constructor will be called by the sub-class
        protected AppDbContext(
            DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }

    /*
    // This DbContext class will be used on the production server
    // I needed a separate class so I can use
    public class ProductionDbContext : AppDbContext
    {
        public ProductionDbContext(
               DbContextOptions<ProductionDbContext> options) : base(options) { }
    }
    */

    public class ProductionDbContext : DbContext
    {
        // This constructor will be called by the DI service set up in Startup
        public ProductionDbContext(
           DbContextOptions<ProductionDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}

/* To create separate migrations for each DbContext user these CLI commands:
 * dotnet ef migrations add Initial --context AppDbContext --output-dir Migrations/Development
 * dotnet ef migrations add Initial --context ProductionDbContext --output-dir Migrations/Production
 */