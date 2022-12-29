using Microsoft.EntityFrameworkCore;

namespace ToDoAPI.Models
{
    /// <summary>
    /// The database context for teh ToDo items.
    /// </summary>
    public class TodoContext : DbContext
    {
        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="options">The database context options</param>
        public TodoContext(DbContextOptions<TodoContext> options) 
            : base(options) 
        { 
        }

        /// <summary>
        /// The collection of Todo items.
        /// </summary>
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
