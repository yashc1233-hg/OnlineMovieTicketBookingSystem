
Added:
- Controllers/DashboardController.cs
- Controllers/DashboardApiController.cs
- Views/Dashboard/Index.cshtml
- wwwroot/js/dashboard.js

Notes:
- These files assume your project uses an ApplicationDbContext with DbSet<Movie> Movies and DbSet<Booking> Bookings.
- If your DbContext class or namespaces differ, adjust the namespace or constructor injection.
- To enable a default post-login redirect to Dashboard, update your login logic to redirect to /Dashboard.
