using Tareas.Models;

namespace Tareas.Services;

public class TodoService
{
    private List<TodoItem> _todos = new List<TodoItem>();

    public List<TodoItem> GetTodos()
    {
        return _todos;
    }

    public void AddTodoItem(TodoItem item)
    {
        item.Id = _todos.Count > 0 ? _todos.Max(t => t.Id) + 1 : 1;
        _todos.Add(item);
    }

    public void AddGeneratedTodoItem(TodoItem item)
    {
        _todos.Add(item);
    }

    public void RemoveTodoItem(int id)
    {
        var item = _todos.FirstOrDefault(t => t.Id == id);
        if (item != null)
        {
            _todos.Remove(item);
        }
    }

    public void RemoveCompletedItems()
    {
        _todos.RemoveAll(t => t.Status == TodoStatus.Completada);
    }

    public void ChangeStatus(int id)
    {
        var item = _todos.FirstOrDefault(t => t.Id == id);
        if (item != null && !item.IsBlocked)
        {
            item.Status = item.Status switch
            {
                TodoStatus.Planificada => TodoStatus.Iniciada,
                TodoStatus.Iniciada => TodoStatus.EnCurso,
                TodoStatus.EnCurso => TodoStatus.Completada,
                _ => item.Status
            };
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}

