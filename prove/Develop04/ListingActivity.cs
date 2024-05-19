using System;
using System.Diagnostics;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Property to store a random prompt
    private string _randomPrompt { get; set; }
    // List of prompts for the activity
    private List<string> _prompts;

    public ListingActivity() : base()
    {
        // Set the name and description of the activity
        SetActivityName("Listing Activity");
        SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        // Initialize the list of prompts
        _prompts = new List<string>
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };
    }

    public void RunListingActivity()
    {
        // Start the activity with parent class methods
        RunActivityParentStart();
        // Display a random prompt to the user
        DisplayPrompt();
        // Count the number of responses the user lists
        ListingCounter();
        // End the activity with parent class methods
        RunActivityParentEnd();
    }

    private void DisplayPrompt()
    {
        // Display instructions and a random prompt
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        int randomIndex = new Random().Next(0, _prompts.Count);
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();
    }

    private void ListingCounter()
    {
        // Get the current time and calculate the end time for the listing activity
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetUserSessionLengthInput());
        DateTime currentTime = DateTime.Now;
        int count = 0;

        // Loop until the current time reaches the future time
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine(); // User inputs a response
            count += 1; // Increment the count of responses
            currentTime = DateTime.Now; // Update the current time
        }

        // Display the total number of items listed by the user
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");
        // Display a spinner for 5 seconds (to simulate a loading or thinking period)
        DisplaySpinner(5);
    }
}
