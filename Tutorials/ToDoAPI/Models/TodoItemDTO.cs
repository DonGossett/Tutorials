namespace ToDoAPI.Models
{
    /// <summary>
    /// The Todo Item DTO (Data Transfer Object)
    /// </summary>
    public class TodoItemDTO
    {
        /// <summary>
        /// The unique Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Whether or not the to do item is complete.
        /// </summary>
        public bool IsComplete { get; set; }
    }
}
