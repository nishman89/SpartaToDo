using SpartaToDo.Models;

namespace SpartaToDo.Services
{
    public interface IToDoService
    {
        public Task<List<ToDo>> GetToDoItemsAsync();
        public Task<ToDo> GetToDoItemByIdAsync(int? id);
        public Task RemoveToDoItemAsync(ToDo todo);
        public Task SaveChangesAsync();
        public bool ToDoItemExists(int id);
        public Task CreateToDoItemAsync(ToDo ToDos);
        public Task<List<ToDo>> GetToDoItemsByUserIdAsync(string id);
    }
}
