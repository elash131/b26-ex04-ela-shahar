using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
	public abstract class Menu
	{
		private readonly string r_Title;
		private readonly List<MenuItem> r_Items;

		protected Menu(string i_Title)
		{
			r_Title = i_Title;
			r_Items = new List<MenuItem>();
		}

		protected bool HasSubItems
		{
			get
			{
				return r_Items.Count > 0;
			}
		}

		public override string ToString()
		{
			return r_Title;
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

		private void runLoop()
		{
			bool shouldContinue = true;

			while(shouldContinue)
			{
				Console.Clear();
				printHeader();
				printItemList();
				printBackOption();

				bool isValid = tryReadUserChoice(out int userChoice);

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
			int underlineLength = r_Title.Length + 6;
			string underline = new string('-', underlineLength);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("** {0} **", r_Title);
			Console.WriteLine(underline);
			Console.ForegroundColor = previousColor;
		}

		private void printItemList()
		{
			int index = 1;

			foreach(MenuItem item in r_Items)
			{
				Console.WriteLine("{0}. {1}", index, item);
				index++;
			}
		}

		private void printBackOption()
		{
			string backLabel = GetBackLabel();

			Console.WriteLine("0. {0}", backLabel);
			Console.Write(
				"Please enter your choice (1-{0} or 0 to {1}): ",
				r_Items.Count,
				backLabel.ToLower());
		}

		private bool tryReadUserChoice(out int o_UserChoice)
		{
			string input = Console.ReadLine();
			bool isValidInteger = int.TryParse(input, out o_UserChoice);

            return  isValidInteger && o_UserChoice >= 0 && o_UserChoice <= r_Items.Count;
		}
	}
}
