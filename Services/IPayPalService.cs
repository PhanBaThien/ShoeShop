
using ShoeShop.Models;

namespace ShoeShop.Services
{
    public interface IPayPalService
    {
        Task<string> CreatePaymentUrl(Order model, HttpContext context);
        Task<bool> ValidatePayment(string paymentId, string payerId);
    }
}
