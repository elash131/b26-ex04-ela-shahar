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
            MenuItem versionCapitalsItem = new MenuItem("Version and Capitals");
            MenuItem countCapitalsItem = new MenuItem("Count Capitals");
            MenuItem showVersionItem = new MenuItem("Show Version");

            showCurrentDateItem.Selected += showCurrentDateItem_Selected;
			showCurrentTimeItem.Selected += showCurrentTimeItem_Selected;
			dateTimeItem.AddMenuItem(showCurrentDateItem);
			dateTimeItem.AddMenuItem(showCurrentTimeItem);
			countCapitalsItem.Selected += countCapitalsItem_Selected;
			showVersionItem.Selected += showVersionItem_Selected;
			versionCapitalsItem.AddMenuItem(countCapitalsItem);
			versionCapitalsItem.AddMenuItem(showVersionItem);
			mainMenu.AddMenuItem(dateTimeItem);
			mainMenu.AddMenuItem(versionCapitalsItem);

			return mainMenu;
		}

		private void showCurrentDateItem_Selected()
		{
			TestActions.ShowCurrentDate();
		}

		private void showCurrentTimeItem_Selected()
		{
			TestActions.ShowCurrentTime();
		}

		private void countCapitalsItem_Selected()
		{
			TestActions.CountCapitals();
		}

		private void showVersionItem_Selected()
		{
			TestActions.ShowVersion();
		}
	}
}
