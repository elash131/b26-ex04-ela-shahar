using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	internal class ShowCurrentDateAction : IMenuItemAction
	{
		public void Execute()
		{
			TestActions.ShowCurrentDate();
		}
	}
}
