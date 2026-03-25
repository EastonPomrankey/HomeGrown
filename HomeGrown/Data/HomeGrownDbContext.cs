using Microsoft.EntityFrameworkCore;
using HomeGrown.Models;

namespace HomeGrown.Data
{
    public class HomeGrownDbContext : DbContext
    {
        public HomeGrownDbContext(DbContextOptions<HomeGrownDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
    }
}