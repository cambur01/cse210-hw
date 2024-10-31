using System;

public abstract class Activity
{
    public DateTime Date { get; private set; }
    public int Duration { get; private set; }

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Duration} min): Distance {GetDistance():0.0} mi, " +
               $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mi";
    }
}