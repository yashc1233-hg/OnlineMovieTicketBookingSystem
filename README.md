
# OnlineMovieTicketBookingSystem

## What is included
- ASP.NET Core 8.0 MVC project
- SQLite database (moviebooking.db will be created automatically)
- ASP.NET Identity configured (Default UI)
- 40 sample movies seeded (Bollywood + Tollywood)
- Movie listing, details, and basic booking pages

## How to run

1. Install .NET 8 SDK: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
2. Open terminal in project folder:
   ```
   cd /path/to/OnlineMovieTicketBookingSystem
   dotnet restore
   dotnet tool install --global dotnet-ef
   dotnet run
   ```
   The app uses `EnsureCreated()` and will auto-create `moviebooking.db` and seed movies.

3. Open browser:
   https://localhost:5001 or https://localhost:7263 (port may vary)

## Notes
- Identity UI pages (Login/Register) are provided by Microsoft.AspNetCore.Identity.UI package.
- For development in VS Code, install C# extension.
