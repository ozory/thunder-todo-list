using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Domain.Entities;

namespace Application.Models;

public static class Extensions
{
    // -------------------------------------------------------------
    // Recently I'am avoiding to use AutoMapper
    // I saw benchmarks illustrating that is slow. So I used
    // extension methods.
    // -------------------------------------------------------------
    public static Todo MapToTodo(this TodoModel todoModel)
    {
        return Todo.Create(
            todoModel.Id,
            todoModel.Name,
            todoModel.IsComplete,
            todoModel.Date
        );
    }

    public static TodoModel MapToTodoModel(this Todo todo)
    {
        return new TodoModel(
            todo.Id,
            todo.Name,
            todo.Date,
            todo.IsComplete);
    }
}
