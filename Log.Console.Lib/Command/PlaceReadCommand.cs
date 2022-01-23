using CLI.Core.Lib;
using Console.Lib;
using Log.Data;

namespace Log.Lib;

public class PlaceReadCommand : ReadCommand<Place>
{
    public PlaceReadCommand(
        TextCommand textCommand
        , IReadCommand<Place> entityReadCommand) 
            : base(textCommand, entityReadCommand)
    {
    }
}