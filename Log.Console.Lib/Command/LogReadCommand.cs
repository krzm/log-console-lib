using CLIFramework;
using CLIHelper;
using CRUDCommandHelper;
using Log.Data;
using Log.Modern.Lib;
using System;

namespace Log.Console.Lib;

public class LogReadCommand : DataCommand<LogModel>
{
	private readonly IReadCommand<LogArgFilter> logReadCommand;
	private readonly IOutput output;

	public LogReadCommand(
		TextCommand textCommand
		, IReadCommand<LogArgFilter> logReadCommand
		, IOutput output)
			: base(textCommand)
	{
		ArgumentNullException.ThrowIfNull(logReadCommand);
		ArgumentNullException.ThrowIfNull(output);

		this.logReadCommand = logReadCommand;
		this.output = output;
	}

	//todo: this needs refactoring
	public override void Execute(object parameter)
	{
		var @params = parameter as string[];
		DateTime? dateParam = default;
		if(@params != null && @params != Array.Empty<string>())
		{
			var result = DateTime.TryParse(@params[0], out DateTime date);
			if(result == false)
				output.Write("Wrong parameter.");
			else
				dateParam = date;
		}
		logReadCommand.Read(new LogArgFilter() { Start = dateParam });
	}
}