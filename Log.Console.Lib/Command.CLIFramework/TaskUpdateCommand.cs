using CLIFramework;
using CLIWizardHelper;
using Log.Data;

namespace Log.Console.Lib;

public class TaskUpdateCommand 
	: DataCommand<Data.Task>
{
    private readonly IUpdateWizard<Data.Task> updateWizard;
    private ICommandRunner? commandRunner;

	public TaskUpdateCommand(
		TextCommand textCommand
		, IUpdateWizard<Data.Task> updateWizard)
		: base(textCommand)
	{
        this.updateWizard = updateWizard;
		ArgumentNullException.ThrowIfNull(this.updateWizard);
    }

	public void SetCommandRunner(ICommandRunner commandRunner)
	{
		this.commandRunner = commandRunner;
		ArgumentNullException.ThrowIfNull(this.commandRunner);
	}

	public override void Execute(object? parameter)
	{
		updateWizard.Update();
		commandRunner?.RunCommand(nameof(Data.Task).ToLowerInvariant());
	}
}