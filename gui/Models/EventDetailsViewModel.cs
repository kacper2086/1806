public class EventDetailsViewModel
{
    public int Id { get; set; } 
    public string Title { get; set; }
    public string Status { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Serwisant { get; set; }
    public int ClientID { get; set; }

    public string DisplayText => $"{Title} - {Status} - {StartDate?.ToShortDateString()} - {EndDate?.ToShortDateString()} - {Serwisant}";
}
