using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to your goal tracker!\n");
        GoalManager test = new GoalManager();
        test.Start();
    }
}