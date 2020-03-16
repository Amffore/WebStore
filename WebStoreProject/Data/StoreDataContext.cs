using Microsoft.EntityFrameworkCore;
using WebStoreProject.Models;

namespace WebStoreProject.Data
{
    public class StoreDataContext : DbContext
    {
        public StoreDataContext(DbContextOptions<StoreDataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}

