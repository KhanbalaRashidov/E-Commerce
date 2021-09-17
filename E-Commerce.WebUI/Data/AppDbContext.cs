using E_Commerce.WebUI.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.WebUI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

    }
}
