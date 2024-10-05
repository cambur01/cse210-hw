using System;

public class Entry
{
    
    public string _date = DateTime.Now.ToShortDateString();

    static PromptGenerator newPrompt = new PromptGenerator();
    public string _promptText = newPrompt.GetRandomPrompt();

    public string _entryText;


    public void Display()
    {
        Console.WriteLine($"{_date}|{_promptText}|{_entryText}");
    }
}