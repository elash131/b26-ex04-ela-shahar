using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	internal class InterfacesMenuDemo : IMenuItemSelectedObserver
	{
		private MenuItem m_ShowCurrentDateItem;
		private MenuItem m_ShowCurrentTimeItem;
		private MenuItem m_CountCapitalsItem;
		private MenuItem m_ShowVersionItem;

		public static void Run()
		{
			InterfacesMenuDemo demo = new InterfacesMenuDemo();

			demo.runMenu();
		}

		private void runMenu()
		{
			MainMenu mainMenu = buildMenu();

			mainMenu.Show();
		}

		private MainMenu buildMenu()
		{
			MainMenu mainMenu = new MainMenu("Interfaces Main Menu");

			MenuItem dateTimeItem = new MenuItem("Show Current Date/Time");
			m_ShowCurrentDateItem = new MenuItem("Show Current Date", this);
			m_ShowCurrentTimeItem = new MenuItem("Show Current Time", this);
			dateTimeItem.AddMenuItem(m_ShowCurrentDateItem);
			dateTimeItem.AddMenuItem(m_ShowCurrentTimeItem);

			MenuItem versionCapitalsItem = new MenuItem("Version and Capitals");
			m_CountCapitalsItem = new MenuItem("Count Capitals", this);
			m_ShowVersionItem = new MenuItem("Show Version", this);
			versionCapitalsItem.AddMenuItem(m_CountCapitalsItem);
			versionCapitalsItem.AddMenuItem(m_ShowVersionItem);

			mainMenu.AddMenuItem(dateTimeItem);
			mainMenu.AddMenuItem(versionCapitalsItem);

			return mainMenu;
		}

		public void MenuItemSelected(MenuItem i_SelectedItem)
		{
			if(i_SelectedItem == m_ShowCurrentDateItem)
			{
				showCurrentDate();
			}
			else if(i_SelectedItem == m_ShowCurrentTimeItem)
			{
				showCurrentTime();
			}
			else if(i_SelectedItem == m_CountCapitalsItem)
			{
				countCapitals();
			}
			else if(i_SelectedItem == m_ShowVersionItem)
			{
				showVersion();
			}
		}

		private void showCurrentDate()
		{
			Console.WriteLine("> Current Date is {0}", DateTime.Now.ToString("dd/MM/yyyy"));
		}

		private void showCurrentTime()
		{
			Console.WriteLine("> Current Time is {0}", DateTime.Now.ToString("HH:mm:ss"));
		}

		private void countCapitals()
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

		private void showVersion()
		{
			Console.WriteLine("App Version: 26.2.4.7310");
		}
	}
}
