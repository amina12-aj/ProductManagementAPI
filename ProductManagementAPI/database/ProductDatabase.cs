using Microsoft.EntityFrameworkCore;
using ProductManagementAPI.model;

namespace ProductManagementAPI.database
{
    public class ProductDatabase: DbContext
    {
        public ProductDatabase(DbContextOptions<ProductDatabase> options): base(options)
        {

        }
        public DbSet<Category>CategoryTable { get; set; }
    }
}
