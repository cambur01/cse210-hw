using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 10, 21), 30, 4.8),
            new Cycling(new DateTime(2024, 10, 23), 45, 20),
            new Swimming(new DateTime(2024, 10, 25), 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}