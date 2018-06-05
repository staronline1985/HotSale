using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesApp.Model
{
    public class ProductMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ICollection<ImageMaster> ImageMasters { get; set; }
        public ICollection<ProductSaleJoin> ProductSaleJoins { get; set; }
    }
}
