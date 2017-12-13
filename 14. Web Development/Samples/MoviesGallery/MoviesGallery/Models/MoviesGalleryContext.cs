using Microsoft.EntityFrameworkCore;

namespace MoviesGallery.Models
{
    public class MoviesGalleryContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MoviesGalleryContext(DbContextOptions<MoviesGalleryContext> options)
            : base(options)
        {

        }
    }
}
