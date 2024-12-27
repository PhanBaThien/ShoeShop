namespace ShoeShop.Models
{
    public class ErrorViewModel
    {
        // thông báo lỗi
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}