using Tareas.Data;
using Tareas.Models;

namespace Tareas.Services;

public class TodoContextService : ContextService<TodoItem>
{
    private readonly TodoContext _context;

    public TodoContextService(TodoContext context) : base(context)
    {
        _context = context;
    }

    public async Task ChangeStatusAsync(int id)
    {
        var item = await _context.TodoItems.FindAsync(id);
        if (item != null && !item.IsBlocked)
        {
            item.Status = item.Status switch
            {
                TodoStatus.Planificada => TodoStatus.Iniciada,
                TodoStatus.Iniciada => TodoStatus.EnCurso,
                TodoStatus.EnCurso => TodoStatus.Completada,
                _ => item.Status
            };
            await _context.SaveChangesAsync();
        }
    }
}

