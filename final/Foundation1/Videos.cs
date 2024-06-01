using System;
//using System.Collections.Generic; // Added to ensure List<T> is recognized

public class Video 
{
    private string _title; // Private field for the title of the video
    private string _author; // Private field for the author of the video
    private double _length; // Private field for the length of the video in seconds
    private List<Comment> _comments = new List<Comment>(); // Private list to store comments for the video

    // Constructor to initialize the video with a title, author, and length
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Method to add a comment to the video
    public void ListComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to count the number of comments
    public int CountComments()
    {
        int count = 0; // Initialize count
        count = _comments.Count; // Get the number of comments in the list
        return count; // Return the count
    }

    // Method to display information about the video
    public void DisplayInfo()
    {
        // Display the title, author, and length of the video
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds");
        Console.WriteLine();

        int commentCount = CountComments(); // Get the number of comments
        Console.WriteLine($"Number of comments: {commentCount}"); // Display the number of comments

        // Loop through each comment in the list and display its information
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }    
    }
}
