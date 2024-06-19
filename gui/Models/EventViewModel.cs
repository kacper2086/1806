public class EventViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime StartDate { get; set; }
    public string Part { get; set; }

    public string DisplayText => $"{Title} - {Part}"; 
    public override string ToString()
    {
        return $"{Title} - {StartDate.ToShortDateString()}";
    }
}
