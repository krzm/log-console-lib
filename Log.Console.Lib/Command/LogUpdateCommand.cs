﻿using CLI.Core.Lib;
using Console.Lib;
using Log.Data;
using System;

namespace Log.Lib;

public class LogUpdateCommand : DataCommand<LogModel>
{
    private readonly IUpdateWizard<LogModel> updateWizard;
    private ICommandRunner commandRunner;

	public LogUpdateCommand(
		TextCommand textCommand
		, IUpdateWizard<LogModel> updateWizard)
			: base(textCommand)
	{
		ArgumentNullException.ThrowIfNull(updateWizard);

        this.updateWizard = updateWizard;
    }

	public void SetCommandRunner(ICommandRunner commandRunner)
	{
		ArgumentNullException.ThrowIfNull(commandRunner);
		this.commandRunner = commandRunner;
	}

	public override void Execute(object parameter)
	{
		updateWizard.Update();
		commandRunner.RunCommand("log");
	}
}