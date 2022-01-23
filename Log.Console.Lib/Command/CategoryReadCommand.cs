using CLI.Core.Lib;
using Console.Lib;
using Log.Data;

namespace Log.Lib;

public class CategoryReadCommand : ReadCommand<Category>
{
    public CategoryReadCommand(
        TextCommand textCommand
        , IReadCommand<Category> readCommand) 
            : base(textCommand, readCommand)
    {
    }
}