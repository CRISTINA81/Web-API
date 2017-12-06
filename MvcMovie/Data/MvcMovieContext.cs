using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
	public class MvcMovieContext : IdentityDbContext<ApplicationUser>
	{
		public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }

        public DbSet<MvcMovie.Models.Review> Review { get; set; }
    }
}
