public class EventUpdateModel
{
    public int Id { get; set; }
    public string Serwisant { get; set; }
    public string Status { get; set; }
    public DateTime? EndDate { get; set; } // Nullable DateTime dla EndDate
}
