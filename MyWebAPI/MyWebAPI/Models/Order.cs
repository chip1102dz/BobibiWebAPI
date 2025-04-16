namespace MyWebAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public required string DateTime { get; set; }
        public required string PaymentMethod { get; set; }
        public int Price { get; set; }
        public int Rate { get; set; }
        public required string Review { get; set; }
        public int Status { get; set; }
        public int Total { get; set; }
        public required string UserEmail { get; set; }
        public int Voucher { get; set; }

        // Quan hệ với User
        public int UserId { get; set; }
        public required User User { get; set; }

        // Quan hệ với Address
        public int AddressId { get; set; }
        public required Address Address { get; set; }

        // Quan hệ nhiều-nhiều với ProductOrder
        public ICollection<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>();
    }
}
