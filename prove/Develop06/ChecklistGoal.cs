using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete() 
    {
        if (_amountCompleted >= _target) 
        {
            return true;
        } 
        else 
        {
            return false;
        }
    }

    public override void GetDetailsString()
    {
        Console.WriteLine($"{_shortName} ({_description}) - Completed {_amountCompleted}/{_target} times");
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}