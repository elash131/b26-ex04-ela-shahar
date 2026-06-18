using System;

namespace Ex04.Menus.Interfaces
{
	public class MenuItem : Menu
	{
		private readonly IMenuItemAction r_Action;

		public MenuItem(string i_Title) : base(i_Title)
		{
			r_Action = null;
		}

		public MenuItem(string i_Title, IMenuItemAction i_Action) : base(i_Title)
		{
			r_Action = i_Action;
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
			if(r_Action != null)
			{
				r_Action.Execute();
			}

			Console.WriteLine();
			Console.WriteLine("Press Enter to return...");
			Console.ReadLine();
		}
	}
}
