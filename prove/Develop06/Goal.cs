using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    // Constructor
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Methods
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual void GetDetailsString()
    {
        Console.WriteLine($"{_shortName} ({_description})");
    }
    public abstract string GetStringRepresentation();

    public string GetPoints()
    {
        return _points;
    }

}
