using System;
// $G$ NTT-999 (-3) Missing namespace.
// $G$ CSS-999 (-3) Every class or interface should be written in different file.

public class ShowVersion : IExecutableAction
{
    public void Execute()
    {
        Console.WriteLine("App Version: 25.2.4.4480");
    }
}

public class CountLowercase : IExecutableAction
{
    public void Execute()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        int count = 0;
        foreach (char c in input)
        {
            if (char.IsLower(c)) count++;
        }
        Console.WriteLine($"There are {count} lowercase letters.");
    }
}

public class ShowDate : IExecutableAction
{
    public void Execute()
    {
        Console.WriteLine($"> Current Date is {DateTime.Now.ToShortDateString()}");
    }
}

public class ShowTime : IExecutableAction
{
    public void Execute()
    {
        Console.WriteLine($"> Current Time is {DateTime.Now.ToShortTimeString()}");
    }
}
