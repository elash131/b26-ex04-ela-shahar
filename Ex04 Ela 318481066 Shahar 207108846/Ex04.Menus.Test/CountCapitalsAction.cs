using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	internal class CountCapitalsAction : IMenuItemAction
	{
		public void Execute()
		{
			TestActions.CountCapitals();
		}
	}
}
