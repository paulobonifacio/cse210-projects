using System;

public class Comment
{
    private string _name; // Private field for the name of the person who made the comment
    private string _text; // Private field for the text of the comment

    // Constructor to initialize the comment with a name and text
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Method to display information about the comment
    public void DisplayInfo()
    {
        // Display the name of the person and the text of the comment
        Console.WriteLine($"{_name} - {_text}");
    }
}
