namespace ToDoAPI.Models
{
    /// <summary>
    /// The Todo Item
    /// </summary>
    public class TodoItem
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

        /// <summary>
        /// A field used to demonstrate hiding a property from view.
        /// </summary>
        public string? Secret { get; set; }
    }
}
