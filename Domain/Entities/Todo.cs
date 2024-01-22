using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Todo
{
    #region PROPERTIES

    public long Id { get; set; }
    public string Name { get; private set; } = null!;
    public bool IsComplete { get; private set; }
    public DateTime Date { get; private set; }

    #endregion

    #region CONSTRUCTORS

    private Todo(long id, string name, bool isComplete, DateTime date)
    {
        Id = id;
        Name = name;
        IsComplete = isComplete;
        Date = date;
    }

    public static Todo Create(long? id, string name, bool isComplete, DateTime date)
    {
        return new Todo(id ?? 0, name, isComplete, date);
    }

    #endregion
}
