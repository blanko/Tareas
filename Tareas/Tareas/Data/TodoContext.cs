namespace Tareas.Data;

using Microsoft.EntityFrameworkCore;
using Tareas.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

    public DbSet<TodoItem> TodoItems { get; set; }
}

