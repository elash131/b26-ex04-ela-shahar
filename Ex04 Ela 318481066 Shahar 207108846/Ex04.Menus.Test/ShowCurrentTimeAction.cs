using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	internal class ShowCurrentTimeAction : IMenuItemAction
	{
		public void Execute()
		{
			TestActions.ShowCurrentTime();
		}
	}
}
