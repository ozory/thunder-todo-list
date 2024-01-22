using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Domain.Entities;

namespace Application.Services
{
    public interface ITodoService
    {
        Task<List<TodoModel>> GetAllAsync();

        Task<TodoModel?> GetByIdAsync(long id);

        Task<TodoModel> CreateAsync(TodoModel todo);

        Task<TodoModel?> UpdateAsync(long id, TodoModel todo);

        Task<bool> DeleteAsync(long id);
    }
}