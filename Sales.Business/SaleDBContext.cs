using Microsoft.EntityFrameworkCore;
using SalesApp.Model;

namespace Sales.Data
{
    public class SaleDBContext : DbContext
    {
        public SaleDBContext(DbContextOptions<SaleDBContext> options) : base(options)
        {
            if (!this.Database.EnsureCreated()) {
              
            }
            
        }
        public DbSet<ProductMaster> ProductMasters { get; set; }
        public DbSet<ImageMaster> ImageMasters { get; set; }
        public DbSet<SaleMaster> SaleMasters { get; set; }
        public DbSet<ProductSaleJoin> ProductSaleJoins { get; set; }
    }

}
