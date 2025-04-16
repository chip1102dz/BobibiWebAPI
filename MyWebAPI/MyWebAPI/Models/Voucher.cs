namespace MyWebAPI.Models
{
    public class Voucher
    {
        public int Id { get; set; }         
        public int Discount { get; set; }    
        public int Minimum { get; set; }    
        public required string Title { get; set; }    
        public required string MinimumText { get; set; } 
        public bool IsSelected { get; set; } 
    }
}
