public class EventViewModel
{
    public string Title { get; set; }
    public DateTime StartDate { get; set; }
    public string Part { get; set; }

    public string DisplayText => $"{Title} - {Part}"; 
    public override string ToString()
    {
        return $"{Title} - {StartDate.ToShortDateString()}";
    }
}
