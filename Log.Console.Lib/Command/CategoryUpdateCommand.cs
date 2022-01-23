using CLI.Core.Lib;
using Console.Lib;
using Log.Data;

namespace Log.Lib;

public class CategoryUpdateCommand : UpdateCommand<Category>
{
    public CategoryUpdateCommand(
        TextCommand textCommand
        , IUpdateWizard<Category> modelAUpdateWizard) 
            : base(textCommand
                , modelAUpdateWizard)
    {
    }
}