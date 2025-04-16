namespace MyWebAPI.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Đổi từ string sang int
        public required string FullAddress { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public bool Selected { get; set; }
        public required User User { get; set; } // Đảm bảo quan hệ hai chiều với User
    }
}