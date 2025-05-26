using Microsoft.EntityFrameworkCore;
using prog_asp.net_mvc_kirusha.Models;

namespace prog_asp.net_mvc_kirusha.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
