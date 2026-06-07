using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
	public abstract class Menu
	{
		private readonly string r_Name;
		private readonly List<MenuItem> r_Items;

		protected Menu(string i_Name)
		{
			r_Name = i_Name;
			r_Items = new List<MenuItem>();
		}

		public string Name
		{
			get
			{
				return r_Name;
			}
		}

		protected bool HasSubItems
		{
			get
			{
				return r_Items.Count > 0;
			}
		}

		public void AddMenuItem(MenuItem i_Item)
		{
			r_Items.Add(i_Item);
		}

		public virtual void Show()
		{
			runLoop();
		}

		protected virtual string GetBackLabel()
		{
			return "Back";
		}

		protected virtual string GetBackActionText()
		{
			return "go back";
		}

		private void runLoop()
		{
			bool shouldContinue = true;

			while(shouldContinue)
			{
				Console.Clear();
				printHeader();
				printItemList();
				printBackOption();

				int userChoice;
				bool isValid = tryReadUserChoice(out userChoice);

				if(!isValid)
				{
					Console.WriteLine("Invalid choice. Press Enter to try again.");
					Console.ReadLine();
				}
				else if(userChoice == 0)
				{
					shouldContinue = false;
				}
				else
				{
					r_Items[userChoice - 1].Show();
				}
			}
		}

		private void printHeader()
		{
			ConsoleColor previousColor = Console.ForegroundColor;
			int underlineLength = r_Name.Length + 6;
			string underline = new string('-', underlineLength);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("** {0} **", r_Name);
			Console.WriteLine(underline);
			Console.ForegroundColor = previousColor;
		}

		private void printItemList()
		{
			for(int i = 0; i < r_Items.Count; i++)
			{
				Console.WriteLine("{0}. {1}", i + 1, r_Items[i].Name);
			}
		}

		private void printBackOption()
		{
			Console.WriteLine("0. {0}", GetBackLabel());
			Console.Write(
				"Please enter your choice (1-{0} or 0 to {1}): ",
				r_Items.Count,
				GetBackActionText());
		}

		private bool tryReadUserChoice(out int o_UserChoice)
		{
			string input = Console.ReadLine();
			bool isValidInteger = int.TryParse(input, out o_UserChoice);
			bool isInRange = isValidInteger && o_UserChoice >= 0 && o_UserChoice <= r_Items.Count;

			return isInRange;
		}
	}
}
