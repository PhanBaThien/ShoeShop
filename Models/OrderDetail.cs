using Microsoft.EntityFrameworkCore;

namespace ShoeShop.Models
{
    public class OrderDetail
    {
        // chi tiết đơn hàng
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int VariantSizeId { get; set; }
        public VariantSize VariantSize { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }  
    }
}
