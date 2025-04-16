namespace MyWebAPI.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public required Order Order { get; set; }
        public int ProductId { get; set; }
        public required Product Product { get; set; }

        public required string Name { get; set; } 
        public required string Description { get; set; } 
        public int Count { get; set; } 
        public int Price { get; set; }
        public required string Image {  get; set; }
    }
}
