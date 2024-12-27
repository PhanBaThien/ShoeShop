using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeShop.Models
{
    public class Image
    {
        // hình ảnh sản phẩm
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? VariantId { get; set; }
    }
}
