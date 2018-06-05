using Microsoft.EntityFrameworkCore;
using SalesApp.Model;

namespace Sales.Data
{
    public class SaleDBContext : DbContext
    {
        public SaleDBContext(DbContextOptions<SaleDBContext> options) : base(options)
        {
            if (!this.Database.EnsureCreated()) {
              //new  DbInitializer(this).InitilizeProducts();
            }
            
        }
        public DbSet<ProductMaster> ProductMasters { get; set; }
        public DbSet<ImageMaster> ImageMasters { get; set; }
        public DbSet<SaleMaster> SaleMasters { get; set; }
        public DbSet<ProductSaleJoin> ProductSaleJoins { get; set; }
    }


    /* Use for dummy data insertion use when run project first time    */
    
    //public  class DbInitializer{

    //    private readonly string IMAGEMASTERPATH = "";
    //    SaleDBContext _db;
    //    public DbInitializer(SaleDBContext _db) {
    //        this._db = _db;
    //    }

    //    private ImageMaster ImageMasterData(int ProductId)
    //    {
    //        var _imageMaster = new ImageMaster { ImageURL = IMAGEMASTERPATH, ProductId = ProductId };
    //        this._db.ImageMasters.Add(_imageMaster);
    //        return _imageMaster;
    //    }

    //    public bool InitilizeProducts()
    //    {
    //        var _ProductMaster = new ProductMaster { ProductName = "A1" };
    //        this._db.ProductMasters.Add(_ProductMaster);
    //        ImageMasterData(_ProductMaster.ProductId);
    //        SaleMaster _saleMaster = null;
    //        if (this._db.SaleMasters.Any())
    //        {
    //             _saleMaster = this._db.SaleMasters.FirstOrDefault();
    //        }
    //        else {
    //            _saleMaster = new SaleMaster { Description = "Diwali Sale", IsActive = true, Title = "Happy Diwali" };
    //            this._db.SaleMasters.Add(_saleMaster);
    //            this._db.SaveChanges();
    //        }
    //        JoinSaleProducts(_ProductMaster, _saleMaster);

    //        this._db.SaveChanges();
    //        return true;
    //    }

    //    private bool JoinSaleProducts(ProductMaster _ProductMaster, SaleMaster _SaleMaster) {
    //        this._db.ProductSaleJoins.Add(new ProductSaleJoin {ProductId=_ProductMaster.ProductId ,SaleId=_SaleMaster.SaleId });
    //        return true;
    //    }




    // }

    
}
