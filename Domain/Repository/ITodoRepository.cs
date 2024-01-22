using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repository
{
    public interface ITodoRepository
    {
        Task<List<Todo>> GetAllAsync();

        Task<Todo?> GetByIdAsync(long id);

        Task<Todo> CreateAsync(Todo todo);

        Task<Todo> UpdateAsync(Todo todo);

        Task<bool> DeleteAsync(Todo todo);
    }
}