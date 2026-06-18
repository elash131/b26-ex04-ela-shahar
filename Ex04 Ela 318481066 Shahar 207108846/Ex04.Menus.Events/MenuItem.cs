using System;

namespace Ex04.Menus.Events
{
	public class MenuItem : Menu
	{
		public event Action Selected;

		public MenuItem(string i_Title) : base(i_Title)
		{
		}

		public override void Show()
		{
			if(!HasSubItems)
			{
				showLeafAction();
			}
			else
			{
				base.Show();
			}
		}

		protected virtual void OnSelected()
		{
            Selected?.Invoke();
        }

		private void showLeafAction()
		{
			Console.Clear();
			OnSelected();
			Console.WriteLine();
			Console.WriteLine("Press Enter to return...");
			Console.ReadLine();
		}
	}
}
