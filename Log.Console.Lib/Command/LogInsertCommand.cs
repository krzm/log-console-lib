﻿using CLI.Core.Lib;
using Console.Lib;
using Log.Data;
using System;

namespace Log.Lib;

public class LogInsertCommand : DataCommand<LogModel>
{
    private readonly IInsertWizard<LogModel> logInsertWizard;
    private ICommandRunner commandRunner;

	public LogInsertCommand(
		TextCommand command
		, IInsertWizard<LogModel> logInsertWizard)
			: base(command)
	{
		ArgumentNullException.ThrowIfNull(logInsertWizard);

        this.logInsertWizard = logInsertWizard;
    } 
	
	public void SetCommandRunner(ICommandRunner commandRunner)
	{
		ArgumentNullException.ThrowIfNull(commandRunner);
		this.commandRunner = commandRunner;
	}
	
	public override void Execute(object parameter)
	{
		logInsertWizard.Insert();
		commandRunner.RunCommand("log");
	}
}