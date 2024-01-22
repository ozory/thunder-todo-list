using Application.Models;
using Application.Validators;
using Domain.Repository;

namespace Application.Services
{
    public class TodoService : ITodoService
    {
        #region PROPERTIES

        private readonly ITodoRepository _todoRepository;

        #endregion

        #region CONSTRUCTORS

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        #endregion

        #region METHODS

        public async Task<TodoModel> CreateAsync(TodoModel todoModel)
        {
            var todo = todoModel!.MapToTodo();

            // Force id to 0 to ensure that is a new entry
            todo.Id = 0;
            todo.Validate(todoModel);

            await _todoRepository.CreateAsync(todo);
            return todo.MapToTodoModel();
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var todo = await _todoRepository.GetByIdAsync(id);
            if (todo == null) return false;

            await _todoRepository.DeleteAsync(todo);
            return true;
        }

        public async Task<List<TodoModel>> GetAllAsync()
        {
            var todos = await _todoRepository.GetAllAsync();
            return todos.Select(x => x.MapToTodoModel()).ToList();
        }

        public async Task<TodoModel?> GetByIdAsync(long id)
        {
            var todo = await _todoRepository.GetByIdAsync(id);
            return todo?.MapToTodoModel() ?? null;
        }

        public async Task<TodoModel?> UpdateAsync(long id, TodoModel todoModel)
        {
            var existentTodo = await _todoRepository.GetByIdAsync(id);
            if (existentTodo == null) return null;

            existentTodo.Validate(todoModel);
            existentTodo = todoModel.MapToTodo();

            await _todoRepository.UpdateAsync(existentTodo);
            return todoModel;
        }

        #endregion
    }
}