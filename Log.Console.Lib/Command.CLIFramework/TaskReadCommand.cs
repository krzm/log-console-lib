using CLIFramework;
using CRUDCommandHelper;
using Log.Data;
using System;

namespace Log.Console.Lib;

public class TaskReadCommand 
	: DataCommand<Task>
{
    private readonly IReadCommand<TaskFilter> readCommand;

    public TaskReadCommand(
		TextCommand textCommand
		, IReadCommand<TaskFilter> readCommand)
			: base(textCommand)
	{
		ArgumentNullException.ThrowIfNull(readCommand);

        this.readCommand = readCommand;
    }

	public override void Execute(object parameter)
	{
		readCommand.Read(new TaskFilter());
	}
}