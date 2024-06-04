using System;

public class StationaryBicycles : Exercise
{
    private double _speed;

    // Constructor to initialize the stationary bicycles exercise with specific details
    public StationaryBicycles(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "Stationary Bicycles";
        _speed = speed;
    }

    // Override method to calculate the distance
    public override double CalculateDistance()
    {
        double distance = _speed * _minutes / 60;
        return distance;
    }

    // Override method to return the speed
    public override double CalculateSpeed()
    {
        return _speed;
    }

    // Override method to calculate the pace
    public override double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}
