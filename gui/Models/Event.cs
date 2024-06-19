namespace YourNamespace.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Serwisant { get; set; }
        public string Part { get; set; }
        public string Status { get; set; }  // Dodano właściwość Status
    }
}
