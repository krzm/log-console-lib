using System.Collections.Generic;
using System.Linq;
using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Log.Data;
using Serilog;

namespace Log.Console.Lib;

public class TaskReadCmd
    : ReadCommand<ILogUnitOfWork, Task, TaskFilter>
{
    private readonly IFilterFactory<Task, TaskFilter> filterFactory;

    public TaskReadCmd(
        ILogUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<Task> textProvider
        , IFilterFactory<Task, TaskFilter> filterFactory) 
            : base(unitOfWork, output, log, textProvider)
    {
        this.filterFactory = filterFactory;
    }

    protected override List<Task> Get(TaskFilter model)
    {
        return UnitOfWork.Task.Get(
            filterFactory.GetFilter(model)
            , orderBy: t => t.OrderBy(p => p.Category.Name)
            , includeProperties: "Category").ToList();
    }
}