
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

public static class SeedMovies
{
    public static async Task EnsureSeedDataAsync(IServiceProvider services)
    {
        using var scope = services.CreateScope();
        var provider = scope.ServiceProvider;
        try
        {
            var db = provider.GetRequiredService<ApplicationDbContext>();
            if (db.Movies.Any()) return; // already seeded

            var movies = new List<Movie> {
                new Movie { MovieId = 101, Title = "Thama", Description = "Horror-comedy — a vampire love saga.", DurationMinutes = 140, Language = "Hindi", PosterPath = "/images/movies/thama.jpg", ReleaseDate = new DateTime(2025,11,1), IsActive=true },
                new Movie { MovieId = 102, Title = "Ek Deewane Ki Deewaniyat", Description = "Romantic drama full of emotions and twists.", DurationMinutes = 130, Language = "Hindi", PosterPath = "/images/movies/ek_deewane.jpg", ReleaseDate = new DateTime(2025,10,21), IsActive=true },
                new Movie { MovieId = 103, Title = "Jawan", Description = "An emotional action thriller where a man faces corruption and injustice.", DurationMinutes = 169, Language = "Hindi", PosterPath = "/images/movies/jawan.jpg", ReleaseDate = new DateTime(2023,9,7), IsActive=true },
                new Movie { MovieId = 104, Title = "Pathaan", Description = "A spy embarks on a dangerous mission to save his nation.", DurationMinutes = 146, Language = "Hindi", PosterPath = "/images/movies/pathaan.jpg", ReleaseDate = new DateTime(2023,1,25), IsActive=true },
                new Movie { MovieId = 105, Title = "Dunki", Description = "A group of friends undertakes an illegal immigration journey.", DurationMinutes = 161, Language = "Hindi", PosterPath = "/images/movies/dunki.jpg", ReleaseDate = new DateTime(2023,12,21), IsActive=true },
                new Movie { MovieId = 106, Title = "Gadar 2", Description = "Sequel to the 2001 hit — a father crosses the border to bring his son home.", DurationMinutes = 170, Language = "Hindi", PosterPath = "/images/movies/gadar2.jpg", ReleaseDate = new DateTime(2023,8,11), IsActive=true },
                new Movie { MovieId = 107, Title = "Brahmāstra: Part One – Shiva", Description = "A young man discovers his connection to a powerful ancient weapon.", DurationMinutes = 167, Language = "Hindi", PosterPath = "/images/movies/brahmastra.jpg", ReleaseDate = new DateTime(2022,9,9), IsActive=true },
                new Movie { MovieId = 108, Title = "Rocky Aur Rani Kii Prem Kahaani", Description = "A love story between two families with opposite cultures and beliefs.", DurationMinutes = 168, Language = "Hindi", PosterPath = "/images/movies/rocky_rani.jpg", ReleaseDate = new DateTime(2023,7,28), IsActive=true },
                new Movie { MovieId = 109, Title = "Bhool Bhulaiyaa 2", Description = "A horror-comedy where a ghost from the past returns to haunt a mansion.", DurationMinutes = 145, Language = "Hindi", PosterPath = "/images/movies/bhool_bhulaiyaa2.jpg", ReleaseDate = new DateTime(2022,5,20), IsActive=true },
                new Movie { MovieId = 110, Title = "Animal", Description = "A complex father-son relationship set against a violent backdrop.", DurationMinutes = 201, Language = "Hindi", PosterPath = "/images/movies/animal.jpg", ReleaseDate = new DateTime(2023,12,1), IsActive=true },
                // South Indian
                new Movie { MovieId = 111, Title = "Pushpa 2: The Rule", Description = "Pushpa rises to rule the red sandalwood empire amidst revenge and rebellion.", DurationMinutes = 180, Language = "Telugu", PosterPath = "/images/movies/pushpa2.jpg", ReleaseDate = new DateTime(2025,5,31), IsActive=true },
                new Movie { MovieId = 112, Title = "Kantara", Description = "A gripping folklore thriller blending tradition, nature, and human greed.", DurationMinutes = 150, Language = "Kannada", PosterPath = "/images/movies/kantara.jpg", ReleaseDate = new DateTime(2022,9,30), IsActive=true },
                new Movie { MovieId = 113, Title = "RRR", Description = "An epic tale of two revolutionaries fighting against British rule.", DurationMinutes = 182, Language = "Telugu", PosterPath = "/images/movies/rrr.jpg", ReleaseDate = new DateTime(2022,3,25), IsActive=true },
                new Movie { MovieId = 114, Title = "KGF: Chapter 2", Description = "Rocky faces his enemies and the government as he fights for dominance over Kolar Gold Fields.", DurationMinutes = 168, Language = "Kannada", PosterPath = "/images/movies/kgf2.jpg", ReleaseDate = new DateTime(2022,4,14), IsActive=true },
                new Movie { MovieId = 115, Title = "Vikram", Description = "A retired agent is drawn back into a world of spies and assassins.", DurationMinutes = 173, Language = "Tamil", PosterPath = "/images/movies/vikram.jpg", ReleaseDate = new DateTime(2022,6,3), IsActive=true },
                new Movie { MovieId = 116, Title = "Jailer", Description = "A prison warden takes justice into his own hands in a dark world of crime.", DurationMinutes = 168, Language = "Tamil", PosterPath = "/images/movies/jailer.jpg", ReleaseDate = new DateTime(2023,8,10), IsActive=true },
                new Movie { MovieId = 117, Title = "Salaar: Part 1 – Ceasefire", Description = "A powerful rebel takes on a ruthless regime to protect his people.", DurationMinutes = 175, Language = "Telugu", PosterPath = "/images/movies/salaar.jpg", ReleaseDate = new DateTime(2023,12,22), IsActive=true },
                new Movie { MovieId = 118, Title = "Leo", Description = "A bakery owner’s violent past resurfaces in this action-packed thriller.", DurationMinutes = 164, Language = "Tamil", PosterPath = "/images/movies/leo.jpg", ReleaseDate = new DateTime(2023,10,19), IsActive=true },
                new Movie { MovieId = 119, Title = "Devara: Part 1", Description = "A man from the coastal region fights for justice and survival.", DurationMinutes = 170, Language = "Telugu", PosterPath = "/images/movies/devara.jpg", ReleaseDate = new DateTime(2025,4,10), IsActive=true },
                new Movie { MovieId = 120, Title = "Kalki 2898 AD", Description = "A futuristic action epic combining mythology and science fiction.", DurationMinutes = 190, Language = "Telugu", PosterPath = "/images/movies/kalki2898ad.jpg", ReleaseDate = new DateTime(2024,6,27), IsActive=true }
            };

            db.Movies.AddRange(movies);
            await db.SaveChangesAsync();
        }
        catch { }
    }
}
