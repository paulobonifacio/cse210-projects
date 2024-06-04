using System;

public class Reception : Event
{
    private string _email;

    // Constructor to initialize the reception with specific details
    public Reception(string title, string description, string date, string time, Address address, string email) 
        : base(title, description, date, time, address)
    {
        _email = email;
    }

    // Method to get the email for RSVP
    public string GetEmail()
    {
        return _email;
    }

    // Method to return the type of event
    public string ReturnEventType()
    {
        return "Reception";
    }

    // Method to generate detailed reception information
    public string GenerateDetailedReception()
    {
        string detailed = GenerateStandard() + "\n";
        detailed += "RSVP: " + _email;
        return detailed;
    }

    // Method to generate short reception information
    public string GenerateShortReception()
    {
        string shortReception = "";
        string eventType = ReturnEventType();
        
        shortReception += "Event Type: " + eventType + "\n";
        shortReception += GenerateShort();
        return shortReception;
    }
}
