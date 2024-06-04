using System;

public class OutdoorGathering : Event
{
    private string _weather;

    // Constructor to initialize the outdoor gathering with specific details
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) 
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    // Method to get the weather information
    public string GetWeather()
    {
        return _weather;
    }

    // Method to generate a weather statement
    public string GenerateWeatherStatement()
    {
        return "The weather will be " + _weather + ".";
    }

    // Method to return the type of event
    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }

    // Method to generate detailed outdoor gathering information
    public string GenerateDetailedOutdoorGathering()
    {
        string detailed = "";
        string weatherStatement = GenerateWeatherStatement();
        
        detailed += GenerateStandard() + "\n";
        detailed += "Statement of the Weather: " + weatherStatement;
        return detailed;
    }

    // Method to generate short outdoor gathering information
    public string GenerateShortOutdoorGathering()
    {
        string shortOG = "";
        string eventType = ReturnEventType();

        shortOG += "Event Type: " + eventType + "\n";
        shortOG += GenerateShort();
        return shortOG;
    }
}
