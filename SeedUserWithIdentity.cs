// SeedUserWithIdentity.cs
// Compile/run this inside your ASP.NET Core project (or add to Program.cs) to create the default Identity user.
// Requires Microsoft.AspNetCore.Identity and your ApplicationDbContext / Identity setup.
// Example usage: call SeedData.EnsureUserAsync(host.Services).Wait();

using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;

public static class SeedData
{
    // Change these values if needed
    public const string DefaultUserName = "yash75";
    public const string DefaultPassword = "752004";
    public const string DefaultEmail = "yash75@example.com";

    public static async Task EnsureUserAsync(IServiceProvider services)
    {
        using (var scope = services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var user = await userManager.FindByNameAsync(DefaultUserName);
            if (user == null)
            {
                user = new IdentityUser { UserName = DefaultUserName, Email = DefaultEmail, EmailConfirmed = true };
                var result = await userManager.CreateAsync(user, DefaultPassword);
                if (!result.Succeeded)
                {
                    Console.WriteLine("Failed to create default user:");
                    foreach (var err in result.Errors) Console.WriteLine(err.Description);
                }
                else
                {
                    Console.WriteLine("Default user created: " + DefaultUserName);
                }
            }
            else
            {
                Console.WriteLine("Default user already exists: " + DefaultUserName);
            }
        }
    }
}
