namespace MyWebAPI.Models
{
    public class Address
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public required string FullAddress { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public bool Selected { get; set; }
        public required string UserEmail { get; set; }
    }
}