namespace MyWebAPI.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public required String Name { get; set; }
        public required String Email { get; set; }
        public required String Comment { get; set; }
        public required String Phone { get; set; }

    }
}
