using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new list
        List<int> numbers = new List<int>();

        // Declare variables to use inside loop
        int newNumber = -1;
        int sum = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            // Get number from the user
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            // As long as the number isn't 0, add to list and total sum
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
                sum += newNumber;
            }
            // Check if the current number is the largest
            if (newNumber > largest)
            {
                largest = newNumber;
            }
        } while (newNumber != 0);
        
        // Calculate the average
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");


    }
}