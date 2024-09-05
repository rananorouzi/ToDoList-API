namespace TodoListApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool IsComplete { get; set; }
    public bool Pending {get; set; }
}