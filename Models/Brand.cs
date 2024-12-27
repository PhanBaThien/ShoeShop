﻿namespace ShoeShop.Models
{
	public class Brand
	{
		// thương hiệu sản phẩm
		public int Id { get; set; }
		public string? Name { get; set; }
		public bool? IsDelete { get; set; } = false;	
        public ICollection<Product>? Products { get; set; }

    }
}