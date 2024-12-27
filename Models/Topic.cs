namespace ShoeShop.Models
{
    public class Topic
    {
        /// class chủ đề
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
