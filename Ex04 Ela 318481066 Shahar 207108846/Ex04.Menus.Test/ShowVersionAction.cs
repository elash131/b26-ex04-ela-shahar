using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	internal class ShowVersionAction : IMenuItemAction
	{
		public void Execute()
		{
			TestActions.ShowVersion();
		}
	}
}
