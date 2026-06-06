using System.Collections.Generic;
using System;
// $G$ DSN-001 (-5) The correct relationship between Menu and MenuItem (which is the "leaf") is:
// The Menu class has a Name property, holds a reference to a list of MenuItem objects, and exposes a Show() method.
// The MenuItem class derives from Menu and holds a reference to an Action event or interface (e.g., IAction).
public class Menu
{
    private readonly string m_Name;
    private readonly List<Menu> m_Items;
    private readonly Action m_Action;

    public Menu(string i_Name, Action i_Action)
    {
        m_Name = i_Name;
        m_Action = i_Action;
        m_Items = null; // leaf
    }

    public Menu(string i_Name)
    {
        m_Name = i_Name;
        m_Items = new List<Menu>();
    }

    public bool IsLeaf => m_Items == null || m_Items.Count == 0;

    public void AddItem(Menu i_Item)
    {
        m_Items?.Add(i_Item);
    }
    // $G$ CSS-021 (-2) The method should be called "OnXXX" where XXX is the name of the event.
    public void Execute()
    {
        if (IsLeaf)
        {
            Console.Clear();
            try
            {
                m_Action?.Invoke();
            }
            catch
            {
                throw;
            }

            Console.WriteLine("\nPress Enter to return...");
            Console.ReadLine();
        }
        else
        {
            while (true)
            {
                Console.Clear();
                // $G$ NTT-999 (-3) You should have use: Environment.NewLine instead of "\n".
                Console.WriteLine($"** {m_Name} **\n");

                for (int i = 0; i < m_Items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {m_Items[i].m_Name}");
                }
                Console.WriteLine("0. Back");
                Console.Write("\nChoose an option: ");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice) &&
                    choice >= 0 && choice <= m_Items.Count)
                {
                    if (choice == 0)
                    {
                        return;
                    }

                    m_Items[choice - 1].Execute();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                }
            }
        }
    }
}
