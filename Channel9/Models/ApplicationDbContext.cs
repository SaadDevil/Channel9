using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Channel9.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Category> Categories { get; set; }
      
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<TVHost> TVHosts { get; set; }
        public DbSet<TVShow> TVShows { get; set; }
    }
}