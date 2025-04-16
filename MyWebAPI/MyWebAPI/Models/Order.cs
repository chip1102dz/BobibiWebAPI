namespace MyWebAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public required string DateTime { get; set; }
        public required string ListProductsName { get; set; }
        public required string PaymentMethod { get; set; }
        public int Price { get; set; }
        public required List<Product> Products { get; set; }
        public int Rate { get; set; }
        public required string Review { get; set; }
        public int Status { get; set; }
        public int Total { get; set; }
        public required string UserEmail { get; set; }
        public int Voucher { get; set; }
        public required Address Address { get; set; }
    }
}
