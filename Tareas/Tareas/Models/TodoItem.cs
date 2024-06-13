namespace Tareas.Models;

public enum TodoStatus
{
    Planificada,
    Iniciada,
    EnCurso,
    Completada
}

public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsBlocked { get; set; } = false;
    public TodoStatus Status { get; set; } = TodoStatus.Planificada;
}
