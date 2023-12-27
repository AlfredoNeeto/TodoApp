
namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<TodoItem> _todoItems;

        public TodoService()
        {
            _todoItems = new List<TodoItem>
            {
                new TodoItem("Comprar café"),
                new TodoItem("Passear com a Mulan")
            };
        }

        public void Add(TodoItem item)
        {
            _todoItems.Add(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItems.ToList();
        }

        public void Delete(TodoItem item)
        {
            _todoItems.Remove(item);
        }

        public void Complete(TodoItem item)
        {
            item.Completed = true;
        }

        public void UnComplete(TodoItem item)
        {
            item.Completed = false;
        }

    }
}
