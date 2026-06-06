namespace Ex04.Menus.Events
{
	public class MainMenu : Menu
	{
		public MainMenu(string i_Name) : base(i_Name)
		{
		}

		protected override string GetBackLabel()
		{
			return "Exit";
		}

		protected override string GetBackActionText()
		{
			return "exit";
		}
	}
}
