namespace Application.Models;

public record TodoModel(long? Id, string Name, DateTime Date, bool IsComplete = false);
