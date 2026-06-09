namespace Ex04.Menus.Events
{
	public class MainMenu : Menu
	{
		public MainMenu(string i_Title) : base(i_Title)
		{
		}

		protected override string GetBackLabel()
		{
			return "Exit";
		}
	}
}
