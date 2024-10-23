using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Jules", "Fractions");
        
        Console.WriteLine($"{assignment1.GetSummary()}\n");

        MathAssignment assignment2 = new MathAssignment("Lucas", "Algebra", "5.2", "6-12");
        
        Console.WriteLine($"{assignment2.GetSummary()}");
        Console.WriteLine($"{assignment2.GetHomeworkList()}\n");

        WritingAssignment assignment3 = new WritingAssignment("Elizabeth", "Exercise Science", "The Effects of Muscular Hypertophy");

        Console.WriteLine($"{assignment3.GetSummary()}");
        Console.WriteLine($"{assignment3.GetWritingInformation()}\n");
    }
}