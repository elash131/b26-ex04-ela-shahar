using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	internal class InterfacesMenuDemo
	{
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
            MenuItem versionCapitalsItem = new MenuItem("Version and Capitals");

            dateTimeItem.AddMenuItem(new MenuItem("Show Current Date", new ShowCurrentDateAction()));
			dateTimeItem.AddMenuItem(new MenuItem("Show Current Time", new ShowCurrentTimeAction()));
			versionCapitalsItem.AddMenuItem(new MenuItem("Count Capitals", new CountCapitalsAction()));
			versionCapitalsItem.AddMenuItem(new MenuItem("Show Version", new ShowVersionAction()));
			mainMenu.AddMenuItem(dateTimeItem);
			mainMenu.AddMenuItem(versionCapitalsItem);

			return mainMenu;
		}
	}
}
