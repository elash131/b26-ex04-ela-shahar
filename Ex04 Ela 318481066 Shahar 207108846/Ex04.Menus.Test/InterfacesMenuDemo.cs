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
            MenuItem versionCapitalsItem = new MenuItem("Version and Capitals");
            m_CountCapitalsItem = new MenuItem("Count Capitals", this);
            m_ShowVersionItem = new MenuItem("Show Version", this);

            dateTimeItem.AddMenuItem(m_ShowCurrentDateItem);
			dateTimeItem.AddMenuItem(m_ShowCurrentTimeItem);
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
				TestActions.ShowCurrentDate();
			}
			else if(i_SelectedItem == m_ShowCurrentTimeItem)
			{
				TestActions.ShowCurrentTime();
			}
			else if(i_SelectedItem == m_CountCapitalsItem)
			{
				TestActions.CountCapitals();
			}
			else if(i_SelectedItem == m_ShowVersionItem)
			{
				TestActions.ShowVersion();
			}
		}
	}
}
