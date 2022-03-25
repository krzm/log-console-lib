using System;
using System.Linq.Expressions;
using Log.Data;

namespace Log.Console.Lib;

#nullable enable
public class TaskFiltrator 
    : IFilterFactory<Task, TaskFilter>
{
    public Expression<Func<Task, bool>>? GetFilter(
        TaskFilter filter)
    {
        if(filter.CategoryId.HasValue 
            && string.IsNullOrWhiteSpace(filter.Name) == false)
        {
            return task => 
                task.CategoryId == filter.CategoryId.Value 
                && task.Name.Contains(filter.Name);
        }
        if(filter.CategoryId.HasValue)
            return task => task.CategoryId == filter.CategoryId.Value;
        if(string.IsNullOrWhiteSpace(filter.Name) == false)
            return task => 
                task.Name.Contains(filter.Name);
        return default;
    }
}