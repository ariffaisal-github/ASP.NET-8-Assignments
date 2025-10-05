using BookShelf.Logging;
using BookShelf.Repositories;
using BookShelf.Services;

var builder = WebApplication.CreateBuilder(args);

// Logging: console + simple file
var filePath = builder.Configuration["Logging:File:Path"] ?? "Logs/app.log";
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddSimpleFile(filePath);

// MVC
builder.Services.AddControllersWithViews();

// DI: repository + service
builder.Services.AddSingleton<IBookRepository, InMemoryBookRepository>();
builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Books/Index");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Books}/{action=Index}/{id?}");

app.Run();
