using System;

public class MenuItemAction : IMenuItem
{
    public string Title { get; }
    private readonly IExecutableAction r_Action;

    public MenuItemAction(string i_Title, IExecutableAction i_Action)
    {
        Title = i_Title;
        r_Action = i_Action;
    }

    public void Execute()
    {
        Console.Clear();
        r_Action.Execute();
        Console.WriteLine();
        Console.WriteLine("Press Enter to return...");
        Console.ReadLine();
    }
}