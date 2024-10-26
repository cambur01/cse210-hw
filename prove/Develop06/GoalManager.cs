using System;
using System.IO.Enumeration;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record an Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count(); i++) 
        {
            Console.Write($"{i + 1}. ");
            if (_goals[i].IsComplete() == true)
            {
                Console.Write("[X] ");
            }
            else
            {
                Console.Write("[ ] ");
            }
            _goals[i].GetDetailsString();
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist): ");
        string goalType = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        
        Console.Write("Description: ");
        string description = Console.ReadLine();
        
        Console.Write("Points: ");
        string points = Console.ReadLine();

        switch (goalType.ToLower())
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "checklist":
                Console.Write("Target completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Unknown goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        string goalIndex = "";
        Console.WriteLine("Which goal did you accomplish?");

        goalIndex = Console.ReadLine();
        int goalIndexInt = int.Parse(goalIndex) - 1;

        if (goalIndexInt >= _goals.Count() || goalIndexInt < 1)
        {
            Console.WriteLine("\nThat goal does not exist.");
        }
        else if (_goals[goalIndexInt].IsComplete() == false)
        {
            _goals[goalIndexInt].RecordEvent();

            int pointsEarned = int.Parse(_goals[goalIndexInt].GetPoints());

            _score += pointsEarned;

            Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("\nThat goal has already been accomplished.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat filename would you like to save your goals under? ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals and score saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat file would you like to load your goals from? ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string goalType = parts[0];
                    string[] details = parts[1].Split(',');

                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(details[0], details[1], details[2]);
                        simpleGoal.RecordEvent();
                        _goals.Add(simpleGoal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(details[0], details[1], details[2]);
                        _goals.Add(eternalGoal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal(details[0], details[1], details[2], int.Parse(details[4]), int.Parse(details[5]));
                        for (int i = 0; i < int.Parse(details[3]); i++)
                        {
                            checklistGoal.RecordEvent();
                        }
                        _goals.Add(checklistGoal);
                    }
                }
            }
            Console.WriteLine("\nGoals and score loaded successfully.");
        }
        else
        {
            Console.WriteLine("\nFile not found.");
        }
    }
}