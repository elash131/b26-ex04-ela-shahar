using System;
using System.Collections.Generic;

public class MenuItemSubMenu : IMenuItem
{
    public string Title { get; }
    private readonly List<IMenuItem> r_Items = new List<IMenuItem>();

    public MenuItemSubMenu(string i_Title)
    {
        Title = i_Title;
    }

    public void AddItem(IMenuItem i_Item)
    {
        r_Items.Add(i_Item);
    }

    public void Execute()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"** {Title} **");
            Console.WriteLine(new string('-', Title.Length + 6));

            for (int i = 0; i < r_Items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {r_Items[i].Title}");
            }
            Console.WriteLine("0. Back");
            Console.Write("Please enter your choice: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 0 && choice <= r_Items.Count)
            {
                if (choice == 0)
                {
                    return;
                }
                else
                {
                    r_Items[choice - 1].Execute();
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}