// $G$ SFN-999 (-7) Project structure not as required. All projects suppose to be under the same solution.
// Program.cs in Ex04.Menus.Test
using System;

public static class Program
{
    // $G$ CSS-999 (-3) The class "Program" should not implement any functions, it should only invoke the "main" function.
    public static void Main()
    {
        Console.WriteLine("Running Delegates Menu:");
        RunDelegatesMenu();

        Console.Clear();

        Console.WriteLine("Running Interfaces Menu:");
        RunInterfacesMenu();

        Console.WriteLine("\nAll menus finished. Goodbye!");
    }

    private static void RunDelegatesMenu()
    {
        Menu mainMenu = BuildDelegatesMenu();
        mainMenu.Execute();
    }

    private static Menu BuildDelegatesMenu()
    {
        var lettersMenu = new Menu("Letters and Version");
        lettersMenu.AddItem(new Menu("Show Version", () => Console.WriteLine("App Version: 25.2.4.4480")));
        lettersMenu.AddItem(new Menu("Count Lowercase Letters", () =>
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLower(c)) count++;
                // $G$ CSS-007 (-2) Missing blank line, after "for" block.
            }
            Console.WriteLine($"There are {count} lowercase letters in your text.");
        }));
        // $G$ SFN-999 (-4) You should not use capabilities not taught in the course, such as the "var" keyword or lambda expressions.
        var timeMenu = new Menu("Show Current Date/Time");
        timeMenu.AddItem(new Menu("Show Current Date", () => Console.WriteLine($"> Current Date is {DateTime.Now.ToShortDateString()}")));
        timeMenu.AddItem(new Menu("Show Current Time", () => Console.WriteLine($"> Current Time is {DateTime.Now.ToShortTimeString()}")));

        var root = new Menu("Delegates Main Menu");
        root.AddItem(lettersMenu);
        root.AddItem(timeMenu);
        return root;
    }

    private static void RunInterfacesMenu()
    {
        IMenuItem mainMenu = BuildInterfacesMenu();  // top-level menu
        mainMenu.Execute();                          // shows Interfaces Main Menu
    }

    private static IMenuItem BuildInterfacesMenu()
    {
        var lettersMenu = new MenuItemSubMenu("Letters and Version");
        lettersMenu.AddItem(new MenuItemAction("Show Version", new ShowVersion()));
        lettersMenu.AddItem(new MenuItemAction("Count Lowercase Letters", new CountLowercase()));

        var timeMenu = new MenuItemSubMenu("Show Current Date/Time");
        timeMenu.AddItem(new MenuItemAction("Show Current Date", new ShowDate()));
        timeMenu.AddItem(new MenuItemAction("Show Current Time", new ShowTime()));

        var root = new MenuItemSubMenu("Interfaces Main Menu");
        root.AddItem(lettersMenu);
        root.AddItem(timeMenu);

        return root;
    }

}
