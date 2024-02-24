using Microsoft.EntityFrameworkCore;

namespace BaylorMission6.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) 
        {
        }

        public DbSet<Rating> Ratings { get; set; } // this DBSET creates my ratings table
    }

}
