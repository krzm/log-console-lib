using CLI.Core.Lib;
using Console.Lib;
using System;

namespace Log.Lib;

public class TaskInsertCommand : DataCommand<Data.Task>
{
    private readonly IInsertWizard<Data.Task> taskInsertWizard;
    private ICommandRunner commandRunner;

	public TaskInsertCommand(
		TextCommand textCommand
		, IInsertWizard<Data.Task> taskInsertWizard) 
		: base(textCommand)
	{
		ArgumentNullException.ThrowIfNull(taskInsertWizard);

        this.taskInsertWizard = taskInsertWizard;
    }

	public void SetCommandRunner(ICommandRunner commandRunner)
	{
		ArgumentNullException.ThrowIfNull(commandRunner);
		this.commandRunner = commandRunner;
	}

	public override void Execute(object parameter)
	{
		taskInsertWizard.Insert();
		commandRunner.RunCommand(TextCommand.TypeName.ToLowerInvariant());
	}
}