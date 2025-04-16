namespace MyWebAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
        public required string ShopName { get; set; }
        public required string ShopAddress { get; set; }
        public required string Avatar { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<UserProduct> UserProducts { get; set; } = new List<UserProduct>();
        public ICollection<Address> Addresses { get; set; } = new List<Address>(); // Đảm bảo mỗi User có nhiều địa chỉ
    }
}
