namespace ShoeShop.Models
{
	public class Color
	{
		// màu sắc sản phẩm
		public int Id { get; set; }
		public string Name { get; set; }
        public bool? IsDelete { get; set; } = false;
    }
}
