using System;
using System.Data;

public class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors
    public Reference(string book, int chapter, int verse)
    {

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        
    }

    // Behaviors
    public string GetDisplayText()
    {
        return "";
    }
}