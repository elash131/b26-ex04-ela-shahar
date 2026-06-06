using System;

namespace Ex04.Menus.Events
{
	public class MenuItem : Menu
	{
		public event EventHandler Selected;

		public MenuItem(string i_Name) : base(i_Name)
		{
		}

		public override void Show()
		{
			if (HasSubItems == false)
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
			if (Selected != null)
			{
				Selected.Invoke(this, EventArgs.Empty);
			}
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
