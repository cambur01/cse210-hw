using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");

        while (Console.ReadKey().Key != ConsoleKey.Enter) 
        { 
        } 

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        for (int i = 0; i < _duration; i += 10)
        {
            DisplayQuestions();
            ShowSpinner(10);
        }

        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        Random random = new Random();
        Console.WriteLine($" --- {_prompts[random.Next(_prompts.Count)]} ---");
    }

    private void DisplayQuestions()
    {
        Random random = new Random();
        Console.Write($"> {_questions[random.Next(_questions.Count)]} ");
    }
}