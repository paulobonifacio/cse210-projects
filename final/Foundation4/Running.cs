using System;

public class Running : Exercise
{
    private double _distance;

    // Constructor to initialize the running exercise with specific details
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _name = "Running";
        _distance = distance;
    }

    // Override method to calculate the distance
    public override double CalculateDistance()
    {
        return _distance;
    }

    // Override method to calculate the speed
    public override double CalculateSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }

    // Override method to calculate the pace
    public override double CalculatePace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
}