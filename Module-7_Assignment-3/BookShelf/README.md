# Solved Assignment (In-Memory MVC, 3-Layer)

Project: **BookShelf** / Namespace: **BookShelf**

- 3-layer: Controller → Service → Repository (in-memory `List<Book>`)
- CRUD for Books (Index/Details/Create/Edit/Delete)
- Try–catch in all controller actions (specific + general)
- User-friendly messages via TempData (shown in _Layout)
- Logging: Console + file (`Logs/app.log` via a simple file logger)
- No EF Core / No ADO.NET
- Dummy data seeded on startup

## Run
- Visual Studio: open the `.sln` and press F5 (or Ctrl+F5)
- CLI: `dotnet restore` then `dotnet run`

Default route: `/Books/Index`
