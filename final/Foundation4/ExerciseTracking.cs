using System;

public class Exercise
{
    protected string _date;
    protected int _minutes;
    protected string _name;

    // Constructor to initialize the exercise with date and duration
    public Exercise(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Virtual method to calculate distance, to be overridden by derived classes
    public virtual double CalculateDistance()
    {
        return 0;
    }

    // Virtual method to calculate speed, to be overridden by derived classes
    public virtual double CalculateSpeed()
    {
        return 0;
    }

    // Virtual method to calculate pace, to be overridden by derived classes
    public virtual double CalculatePace()
    {
        return 0;
    }

    // Method to generate a summary of the exercise
    public string GetSummary()
    {
        string summary = $"{_date} {_name} ({_minutes} min) - Distance: {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
        return summary;
    }
}
