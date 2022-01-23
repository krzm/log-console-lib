using CLI.Core.Lib;
using Console.Lib;
using Log.Data;

namespace Log.Lib;

public class CategoryInsertCommand : InsertCommand<Category>
{
    public CategoryInsertCommand(
        TextCommand textCommand
        , IInsertWizard<Category> categoryWizard)
            : base(textCommand, categoryWizard)
    {
    }
}