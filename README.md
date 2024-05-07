# Password Manager

App on WinForms with password encryption and storing data locally in a Sqlite.

## Features

- Adding/Editing/Deleting/Reading Categories
- Adding/Editing/Deleting/Reading Notes with passwords
- Managing profiles with different notes
- Password encryption
- Password generator

## Programming Principles (5)

### Separation of Concerns

The app has 4 layers. **Domain layer** contains entities and general services, which provide business logic. Domain is able to move to different projects and doesn't have dependencies. **Infrastructure layer** has database context and repositories to manipulate data. This layer maps entities from domain to database. **Services** contain classes that use repositories and encapsulate actions that can be used in the app. **Presentation layer** responsible for UI and registering all services.

### DRY

Putting textbox with hiding and auto generating password in a separate [UserControl](Presentation/Views/PasswordInputUC.cs) for reusing.

### KISS

All classes and methods follow simple and readable structure

### YAGNI

Entities, Services and Repositories implement only useful functionality.

### Dependency Inversion

Views(Forms), Repositories, Services implement own interfaces and they are used as dependency in constructor parameters. Also all services are registered in [Program.cs](Presentation\Program.cs#L49-L73) with Service Container from Dependency Injection extension.

## Refactoring Techniques (3)

### Extract Method

Some presenters have private methods with grouped actions (e.g. clearing table in view and fill it again) to avoid duplication.

```c#
categoriesPresenter.CategoriesChanged += Refresh;
editNotePresenter.NoteSaved += Refresh;
```

```c#
// ...
private void Refresh(object? sender, EventArgs e)
{
    View.ClearTable();
    View.FillDataGridView(profile.Notes);
}
```

### Inline Temp

```c#
public Category? GetById(Guid id)
{
    return categoryRepository.GetById(id);
}
```

### Duplicate Observed Data

Domain objects are separated into separate classes

```c#
public class Note : Entity
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }

    public Guid ProfileId { get; set; }
    public Profile Profile { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
```

## Design Patterns (3)

### Observer

Views and Presenters are communicating with each other through Event Handlers. For example, presenter are subscribed to a add note click event. Presenter are responsible for process data and manipulate view.

**Presenter:**

```c#
public class CategoriesPresenter : BasePresenter<ICategoriesView>
{
    // ...
    public CategoriesPresenter(ICategoriesView view, AddCategoryPresenter addCategoryPresenter, ICategoryService categoryService) : base(view)
    {
        // ...
        View.UpdateCategory += UpdateCategory;
        View.DeleteCategory += DeleteCategory;
        // ...
    }

    private void DeleteCategory(object? sender, Guid e)
    {
        categoryService.Delete(e);
        RefreshData();
        CategoriesChanged?.Invoke(this, EventArgs.Empty);
    }

    private void AddCategory(object? sender, EventArgs e)
    {
        addCategoryPresenter.Run();
    }
    // ...
}
```

**View:**

```c#
public partial class CategoriesForm : Form, ICategoriesView
{
    // ...
    public event EventHandler<Guid>? DeleteCategory;
    public event EventHandler<(Guid, string)>? UpdateCategory;
    public event EventHandler? AddCategory;
    // ...

    private void deleteButton_Click(object sender, EventArgs e)
    {
        DeleteCategory?.Invoke(this, selectedCategoryId);
        ResetInputs();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        AddCategory?.Invoke(this, EventArgs.Empty);
    }
    // ...
}
```

### Builder

[PasswordGenerator](Domain\PasswordGenerator.cs) use Builder Pattern to _tick_ which symbols to use for generating password. In addition class provides fluent interface

```c#
textBoxPassword.Text = new PasswordGenerator().IncludeUppercase()
                                              .IncludeDigits()
                                              .IncludeSpecialSymbols()
                                              .Generate(new Random().Next(8, 16));
```

### Factory

Encapsulate initialization of MainPresenter into a [MainPresenterFactory](Presentation\MainPresenterFactory.cs) to make code cleaner
