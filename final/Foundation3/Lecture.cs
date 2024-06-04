using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Constructor to initialize the lecture with specific details
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) 
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Method to get the speaker's name
    public string GetSpeaker()
    {
        return _speaker;
    }

    // Method to get the capacity of the lecture
    public int GetCapacity()
    {
        return _capacity;
    }

    // Method to return the type of event
    public string ReturnEventType()
    {
        return "Lecture";
    }

    // Method to generate detailed lecture information
    public string GenerateDetailedLecture()
    {
        string detailed = GenerateStandard() + "\n";
        detailed += "Speaker: " + _speaker + "\n";
        detailed += "Capacity: " + _capacity + " max";
        return detailed;
    }

    // Method to generate short lecture information
    public string GenerateShortLecture()
    {
        string shortLecture = "";
        string eventType = ReturnEventType();

        shortLecture += "Event Type: " + eventType + "\n";
        shortLecture += GenerateShort();
        return shortLecture;
    }
}
