using Microsoft.EntityFrameworkCore;

namespace ASP_API.Data
{
    public class VideoGameDBContext(DbContextOptions<VideoGameDBContext> options) : DbContext(options)
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame
                {
                    Id = 1,
                    Title = "Spider-Man 2",
                    Platform = "PS5",
                    Developer = "Insomniac Games",
                    Publisher = "Sony Interactive Entertainment"
                },
                    new VideoGame
                    {
                        Id = 2,
                        Title = "Superman Reborn",
                        Platform = "Nintendo",
                        Developer = "AMG Performance",
                        Publisher = "ITC Studios"
                    },
                    new VideoGame
                    {
                        Id = 3,
                        Title = "Lost in Space",
                        Platform = "PC",
                        Developer = "Terraform Games",
                        Publisher = "IDP Ent"
                    }
                    );
        }

    };
};
