using CLIFramework;
using CLIWizardHelper;
using Log.Data;
using System;

namespace Log.Console.Lib;

public class TaskUpdateCommand 
	: DataCommand<Task>
{
    private readonly IUpdateWizard<Task> updateWizard;
    private ICommandRunner commandRunner;

	public TaskUpdateCommand(
		TextCommand textCommand
		, IUpdateWizard<Task> updateWizard)
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
		commandRunner.RunCommand(nameof(Data.Task).ToLowerInvariant());
	}
}