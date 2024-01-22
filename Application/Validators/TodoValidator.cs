using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Domain.Entities;
using Domain.Repository;

namespace Application.Validators
{
    public static class TodoValidator
    {
        public static void Validate(this Todo todo, TodoModel? todoModel)
        {
            ArgumentNullException.ThrowIfNull(todo.Name, "Please input a todo item name");
            if (todoModel?.Id != null && (todo.Id != todoModel.Id)) throw new Exception("Id mismatch");
        }
    }
}