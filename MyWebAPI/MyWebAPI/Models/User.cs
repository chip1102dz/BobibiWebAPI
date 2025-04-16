﻿namespace MyWebAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
        public required String ShopName { get; set; }
        public required String ShopAddress { get; set; }
        public required String Avatar { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<UserProduct> UserProducts { get; set; } = new List<UserProduct>();
    }
}
