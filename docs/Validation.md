# CS295N-Bookinfo-Core-21

# Changes on the validation branch

## Changes to the models

- Author: no changes

- Book:

  ```C#
  [StringLength(100, MinimumLength = 2)]  
  [Required]
  public string Title { get; set; }
  ```

- Comment: no changes

- Review: no changes

- User: no changes



## Changes to the controller methods

- BookContrller:

  ```C#
  [HttpPost]
          public RedirectToActionResult AddBook(Book book,
                                                string author)
          {
              if (ModelState.IsValid)
              {
                  book.Authors.Add(new Author() { Name = author });
                  repo.AddBook(book);  
              }
              return RedirectToAction("Index");
          }
  ```

- AuthorController: No changes



## Changes to the views

- Book/AddBook.cshtml

  ```html
        <div asp-validation-summary="ModelOnly" style="background-color: red"></div>
          <label asp-for="Title">Title</label>
          <div><span asp-validation-for="Title"> </span></div>
          <input asp-for="Title" /><br />
  ```

  Just the `asp-validation-summary` and `asp-validation-for` were added on this branch.