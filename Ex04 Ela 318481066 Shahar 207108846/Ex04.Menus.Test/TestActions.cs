using System;

namespace Ex04.Menus.Test
{
	internal static class TestActions
	{
		public static void ShowCurrentDate()
		{
			Console.WriteLine("> Current Date is {0}", DateTime.Now.ToString("dd/MM/yyyy"));
		}

		public static void ShowCurrentTime()
		{
			Console.WriteLine("> Current Time is {0}", DateTime.Now.ToString("HH:mm:ss"));
		}

		public static void CountCapitals()
		{
			int count = 0;
			string input;

			Console.Write("Enter a sentence: ");
			input = Console.ReadLine();
			foreach(char c in input)
			{
				if(char.IsUpper(c))
				{
					count++;
				}
			}

			Console.WriteLine("> There are {0} uppercase letters in your text", count);
		}

		public static void ShowVersion()
		{
			Console.WriteLine("App Version: 26.2.4.7310");
		}
	}
}
