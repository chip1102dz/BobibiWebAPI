namespace MyWebAPI.Models
{
    public class ProductRating
    {
        public int Id { get; set; }

        public required string UserId { get; set; }
        public int ProductId { get; set; }

        public double Rate { get; set; }
        public required string Review { get; set; }

        public required Product Product { get; set; }

    }
}
