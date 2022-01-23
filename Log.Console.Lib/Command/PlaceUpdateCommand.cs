using CLI.Core.Lib;
using Console.Lib;
using Log.Data;

namespace Log.Lib;

public class PlaceUpdateCommand : UpdateCommand<Place>
{
    public PlaceUpdateCommand(
        TextCommand textCommand
        , IUpdateWizard<Place> modelAUpdateWizard) 
            : base(textCommand, modelAUpdateWizard)
    {
    }
}