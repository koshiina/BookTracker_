using Microsoft.EntityFrameworkCore;
using BookTracker_.Models;

namespace BookTracker_.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options);
        public DbContext
    }
}
