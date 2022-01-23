using CLI.Core.Lib;
using Console.Lib;
using Log.Data;

namespace Log.Lib;

public class PlaceInsertCommand : InsertCommand<Place>
{
    public PlaceInsertCommand(
        TextCommand textCommand
        , IInsertWizard<Place> modelAInsertCommand) 
            : base(textCommand, modelAInsertCommand)
    {
    }
}