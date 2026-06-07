using System;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
	internal class EventsMenuDemo
	{
		public static void Run()
		{
			EventsMenuDemo demo = new EventsMenuDemo();

			demo.runMenu();
		}

		private void runMenu()
		{
			MainMenu mainMenu = buildMenu();

			mainMenu.Show();
		}

		private MainMenu buildMenu()
		{
			MainMenu mainMenu = new MainMenu("Delegates Main Menu");

			MenuItem dateTimeItem = new MenuItem("Show Current Date/Time");
			MenuItem showCurrentDateItem = new MenuItem("Show Current Date");
			MenuItem showCurrentTimeItem = new MenuItem("Show Current Time");

			showCurrentDateItem.Selected += showCurrentDateItem_Selected;
			showCurrentTimeItem.Selected += showCurrentTimeItem_Selected;
			dateTimeItem.AddMenuItem(showCurrentDateItem);
			dateTimeItem.AddMenuItem(showCurrentTimeItem);

			MenuItem versionCapitalsItem = new MenuItem("Version and Capitals");
			MenuItem countCapitalsItem = new MenuItem("Count Capitals");
			MenuItem showVersionItem = new MenuItem("Show Version");

			countCapitalsItem.Selected += countCapitalsItem_Selected;
			showVersionItem.Selected += showVersionItem_Selected;
			versionCapitalsItem.AddMenuItem(countCapitalsItem);
			versionCapitalsItem.AddMenuItem(showVersionItem);

			mainMenu.AddMenuItem(dateTimeItem);
			mainMenu.AddMenuItem(versionCapitalsItem);

			return mainMenu;
		}

		private void showCurrentDateItem_Selected(object sender, EventArgs e)
		{
			Console.WriteLine("> Current Date is {0}", DateTime.Now.ToString("dd/MM/yyyy"));
		}

		private void showCurrentTimeItem_Selected(object sender, EventArgs e)
		{
			Console.WriteLine("> Current Time is {0}", DateTime.Now.ToString("HH:mm:ss"));
		}

		private void countCapitalsItem_Selected(object sender, EventArgs e)
		{
			int count = 0;
			string input;

			Console.Write("Enter a sentence: ");
			input = Console.ReadLine();
			foreach(char c in input)
			{
				if(char.IsUpper(c))
				{
					count++;
				}
			}

			Console.WriteLine("> There are {0} uppercase letters in your text", count);
		}

		private void showVersionItem_Selected(object sender, EventArgs e)
		{
			Console.WriteLine("App Version: 26.2.4.7310");
		}
	}
}
