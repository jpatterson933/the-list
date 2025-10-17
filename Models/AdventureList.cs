namespace LaAdventuresList.Models;

public class AdventureList
{
    public List<string> Completed { get; set; } = new();
    public List<string> NewTodos { get; set; } = new();
    public List<string> Todos { get; set; } = new();
    public List<string> ShowsAndEntertainment { get; set; } = new();
    public List<string> Food { get; set; } = new();
    public List<string> External { get; set; } = new();
}
