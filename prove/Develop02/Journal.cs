using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>
    {};


    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine("");
        Console.WriteLine(newEntry._promptText);
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
        Console.WriteLine("");
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayAll()
    {
        foreach (var Entry in _entries)
        {
            Console.WriteLine("");
            Console.WriteLine($"{Entry._date}");
            Console.WriteLine($"{Entry._promptText}");
            Console.WriteLine($"{Entry._entryText}");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                sw.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Journal saved successfully!");
    }
    public void LoadFromFile(string file)
    {
        string[] journal = System.IO.File.ReadAllLines(file);

        foreach (string entry in journal)
        {
            Entry newEntry = new Entry();

            string[] parts = entry.Split("|");

            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
        Console.WriteLine("");
        Console.WriteLine("Journal loaded successfully!");
    }
}