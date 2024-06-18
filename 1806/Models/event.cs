public class Event
{
    public int Id { get; set; }  // Zmieniłem nazwę właściwości na 'Id' aby była zgodna z konwencją PascalCase
    public string Title { get; set; }  // Zmieniłem nazwę właściwości na 'Title' aby była zgodna z konwencją PascalCase
    public DateTime? StartDate { get; set; }  // Zmieniłem nazwę właściwości na 'StartDate' oraz dodałem nullable
    public DateTime? EndDate { get; set; }  // Zmieniłem nazwę właściwości na 'EndDate' oraz dodałem nullable
    public string Serwisant { get; set; }  // Nullable string
    public string PartName { get; set; }  // Nullable string
}
