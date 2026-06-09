namespace Ex04.Menus.Interfaces
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
