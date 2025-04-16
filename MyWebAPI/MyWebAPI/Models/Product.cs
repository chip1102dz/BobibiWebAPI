namespace MyWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Banner { get; set; }
        public int CategoryId { get; set; }
        public required string Description { get; set; }
        public bool Featured { get; set; }
        public required string Image { get; set; }
        public required string Info { get; set; }
        public required string Name { get; set; }
        public double Price { get; set; }
        public int Sale { get; set; }
        public Category Category { get; set; } = null!;
        public ICollection<ProductRating> Ratings { get; set; } = new List<ProductRating>();
        public ICollection<UserProduct> UserProducts { get; set; } = new List<UserProduct>();
        public ICollection<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>();
    }

}
