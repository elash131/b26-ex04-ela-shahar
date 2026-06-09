using System;

namespace Ex04.Menus.Interfaces
{
	public class MenuItem : Menu
	{
		private readonly IMenuItemSelectedObserver r_Observer;

		public MenuItem(string i_Title) : base(i_Title)
		{
			r_Observer = null;
		}

		public MenuItem(string i_Title, IMenuItemSelectedObserver i_Observer) : base(i_Title)
		{
			r_Observer = i_Observer;
		}

		public override void Show()
		{
            if (!HasSubItems)
            {
                showLeafAction();
            }
            else
            {
                base.Show();
            }
        }

		private void showLeafAction()
		{
			Console.Clear();
			r_Observer?.MenuItemSelected(this);

			Console.WriteLine();
			Console.WriteLine("Press Enter to return...");
			Console.ReadLine();
		}
	}
}
