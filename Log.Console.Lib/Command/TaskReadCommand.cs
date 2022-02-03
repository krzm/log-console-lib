﻿using CLIFramework;
using CRUDCommandHelper;
using Log.Data;
using Log.Modern.Lib;
using System;

namespace Log.Console.Lib;

public class TaskReadCommand : DataCommand<Task>
{
    private readonly IReadCommand<TaskArgFilter> logReadCommand;

    public TaskReadCommand(
		TextCommand textCommand
		, IReadCommand<TaskArgFilter> logReadCommand)
			: base(textCommand)
	{
		ArgumentNullException.ThrowIfNull(logReadCommand);

        this.logReadCommand = logReadCommand;
    }

	public override void Execute(object parameter)
	{
		logReadCommand.Read(default);
	}
}