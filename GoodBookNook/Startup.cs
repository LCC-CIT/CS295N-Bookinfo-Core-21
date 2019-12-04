using GoodBookNook.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodBookNook
{
    public class Startup
    {
        private IHostingEnvironment environment;
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            environment = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Inject our repositories into our controllers
            services.AddTransient<IBookRepository, BookRepository>();

            // We're assuming your developmnet machine uses SQL Server
            // and your production platform uses MySQL or MariaDb
            if (environment.IsDevelopment())
            {
                services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                    Configuration["ConnectionStrings:MsSqlConnection"]));
            }
            else if (environment.IsProduction())
            {
                services.AddDbContext<AppDbContext>(options => options.UseMySql(
                    Configuration["ConnectionStrings:MySqlConnection"]));
            }

            /*   // For Mac OS with SQLite
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlite(
                    Configuration["ConnectionStrings:SQLiteConnection"]));
            */
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, AppDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            // Create or update the database and apply migrations.
            context.Database.Migrate();

            // Add a book and review or two as sample/test data.
            SeedData.Seed(context);
        }

    }
}
