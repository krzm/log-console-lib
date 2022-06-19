using CLIFramework;
using CLIWizardHelper;

namespace Log.Console.Lib;

public class TaskInsertCommand 
	: DataCommand<Data.Task>
{
    private readonly IInsertWizard<Data.Task> taskInsertWizard;
    private ICommandRunner? commandRunner;

	public TaskInsertCommand(
		TextCommand textCommand
        , IInsertWizard<Data.Task> taskInsertWizard) 
		    : base(textCommand)
	{
        this.taskInsertWizard = taskInsertWizard;
		ArgumentNullException.ThrowIfNull(this.taskInsertWizard);
    }

	public void SetCommandRunner(ICommandRunner commandRunner)
	{
		this.commandRunner = commandRunner;
		ArgumentNullException.ThrowIfNull(this.commandRunner);
	}

	public override void Execute(object? parameter)
	{
		taskInsertWizard.Insert();
        ArgumentNullException.ThrowIfNull(TextCommand.TypeName);
		commandRunner?.RunCommand(TextCommand.TypeName.ToLowerInvariant());
	}
}