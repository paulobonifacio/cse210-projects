using System;

// Define the Swimming class that inherits from the Exercise base class
public class Swimming : Exercise
{
    // Private field to store the number of laps
    private double _laps;

    // Constructor for the Swimming class
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        // Set the name of the exercise to "Swimming"
        _name = "Swimming";

        // Store the number of laps
        _laps = laps;
    }

    // Method to calculate the total distance swam in kilometers
    public override double CalculateDistance()
    {
        // Convert to kilometers
        double distance = _laps * 50 / 1000;
        return distance;
    }

    // Method to calculate the average speed in kilometers per hour
    public override double CalculateSpeed()
    {
        // Calculate speed by dividing distance by time (minutes converted to hours)
        double speed = CalculateDistance() / _minutes * 60;
        return speed;
    }

    // Method to calculate the pace in minutes per kilometer
    public override double CalculatePace()
    {
        // Calculate pace by dividing time by distance
        double pace = _minutes / CalculateDistance();
        return pace;
    }
}