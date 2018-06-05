using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesApp.Model
{
    public class ImageMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        [ForeignKey("ProductMaster")]
        public int ProductId { get; set; }
        public string ImageURL { get; set; }
        public ProductMaster ProductMaster { get; set; }
    }
}
