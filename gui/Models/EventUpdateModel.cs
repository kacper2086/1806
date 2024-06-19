public class EventUpdateModel
{
    public int Id { get; set; }
    public string Serwisant { get; set; }
    public string Status { get; set; }
    public DateTime? EndDate { get; set; } // Opcjonalne, jeśli chcesz ustawić datę zakończenia
}
