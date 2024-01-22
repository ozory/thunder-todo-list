using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class TodoRepository : ITodoRepository
    {
        #region PROPERTIES

        private TodoContext _context;

        #endregion

        #region CONSTRUCTORS

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        #endregion

        #region METHODS

        public async Task<Todo> CreateAsync(Todo todo)
        {
            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        public async Task<bool> DeleteAsync(Todo todo)
        {
            _context.Todos.Remove(todo!);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Todo>> GetAllAsync()
        {
            return await _context.Todos
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Todo?> GetByIdAsync(long id)
        {
            return await _context.Todos.FindAsync(id);
        }

        public async Task<Todo> UpdateAsync(Todo todo)
        {
            _context.Update(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        #endregion
    }
}