# BookInfo ASP.NET Core 2 MVC Web App
This web app was written to demonstrate key concepts in development of ASP.NET Core MVC 2 web apps using Visual Studio 2017. Each of the following branches demonstrates a concept or technique:

1. Initial: This branch has place-holder views and controllers to minimally support them. (Updated the project to ASP.NET Core 2.2)
2. DomainModel: Models and a "fake" repository were added as well as view and controller code to minimally test some of the models. An UML class diagram of the domain model is included.
3. Lambda+ComplexModel: In spite of the name, the model is the same as the one on the DomainModel branch, but this branch does use a lambda expression in the Index method of the BookController.
4. Layouts: A shared _Layout.cshtml view is used.
5. UnitTests: Added fake repositories and unit tests.
6. EF: Added EntityFramework and a database
7. EF-SeedData: Added code to seed the database
8. EF-MS+MySQL: Modified Startup to use different database providers depending on the environment MSSQL for development and MySQL for production.
9. Linq: More examples of using LINQ.
10. [Validation](docs/validation.md): Added validation to approriate models and controller methods.


----

This demo was written by [Brian Bird](https://profbird.online for CS295N, Web Development 1: ASP.NET, at Lane Community College.

