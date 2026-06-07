using System;

namespace Ex04.Menus.Interfaces
{
	public class MenuItem : Menu
	{
		private IMenuItemSelectedObserver m_Observer;

		public MenuItem(string i_Name) : base(i_Name)
		{
			m_Observer = null;
		}

		public MenuItem(string i_Name, IMenuItemSelectedObserver i_Observer) : base(i_Name)
		{
			m_Observer = i_Observer;
		}

		public override void Show()
		{
			if(HasSubItems)
			{
				base.Show();
			}
			else
			{
				showLeafAction();
			}
		}

		private void showLeafAction()
		{
			Console.Clear();
			if(m_Observer != null)
			{
				m_Observer.MenuItemSelected(this);
			}

			Console.WriteLine();
			Console.WriteLine("Press Enter to return...");
			Console.ReadLine();
		}
	}
}
