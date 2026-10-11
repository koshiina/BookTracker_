using Microsoft.EntityFrameworkCore;
using BookTracker_.Models;

namespace BookTracker_.Data
{
    public class AppContextB : DbContext
    {
        public AppContextB(DbContextOptions<AppContextB> options) : base(options) { }
        public DbSet<Parameters> Parameters { get; set; }
    }
}
