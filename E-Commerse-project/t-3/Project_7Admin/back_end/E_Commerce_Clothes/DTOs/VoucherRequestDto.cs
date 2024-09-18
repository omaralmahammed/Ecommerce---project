using E_Commerce_Clothes.Models;

namespace E_Commerce_Clothes.DTOs
{
    public class VoucherRequestDto
    {
        public string? Code { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime ExpiryDate { get; set; }


    }
}
