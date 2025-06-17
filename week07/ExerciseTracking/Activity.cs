using System;

public abstract class Activity
{
    private DateTime _date;
    private int _duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetDateString()
    {
        return _date.ToString("dd MMM yyyy");
    }

    public abstract double GetDistance();  // in miles
    public abstract double GetSpeed();     // in mph
    public abstract double GetPace();      // in min/mile

    public virtual string GetSummary()
    {
        return GetDateString() + " " + GetType().Name + " (" + _duration + " min): " +
               "Distance: " + GetDistance().ToString("0.0") + " miles, " +
               "Speed: " + GetSpeed().ToString("0.0") + " mph, " +
               "Pace: " + GetPace().ToString("0.0") + " min per mile";
    }
}
