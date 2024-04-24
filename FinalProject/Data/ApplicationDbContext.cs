using FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BoardGame> BoardGames { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BoardGame>().HasData(
                new BoardGame
                {
                    ID = 1,
                    Name = "Monoply",
                    Company = "Hasbro",
                    Players = 8,
                    Image = "monoply.jpg",
                    Price = 20.00
                },
                new BoardGame
                {
                    ID = 2,
                    Name = "Fallout",
                    Company = "Bethesda",
                    Players = 8,
                    Image = "fallout.jpg",
                    Price = 60.00
                },
                new BoardGame
                {
                    ID= 3,
                    Name = "Settlers of Catan",
                    Company = "Klaus Teuber",
                    Players = 4,
                    Image = "settlers.jpg",
                    Price = 10.00
                },
                new BoardGame
                {
                    ID = 4,
                    Name = "Sorry",
                    Company = "Hasbro",
                    Players = 4,
                    Image = "sorry.jpg",
                    Price = 30.00
                },
                new BoardGame
                {
                    ID = 5,
                    Name = "Elder Scrolls: Skyrim",
                    Company = "Bethesda",
                    Players = 4,
                    Image = "skyrim.jpg",
                    Price = 60.00
                }
                );
        }
    }
}
