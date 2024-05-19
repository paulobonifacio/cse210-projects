using System;
using System.Diagnostics;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    // Lists to store prompts and questions
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base()
    {
        // Set the name and description of the activity
        SetActivityName("Reflection Activity");
        SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        // Initialize the list of prompts
        _prompts = new List<string>
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };

        // Initialize the list of questions
        _questions = new List<string> 
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunReflectingActivity()
    {
        // Start the activity with parent class methods
        RunActivityParentStart();
        // Display a random prompt to the user
        DisplayPrompt();
        // Display reflection questions to the user
        DisplayQuestions();
        // End the activity with parent class methods
        RunActivityParentEnd();
    }

    public void DisplayPrompt()
    {
        // Display instructions and a random prompt
        Console.WriteLine("Consider the following: ");
        Console.WriteLine();

        // Select a random prompt from the list
        int randomIndex = new Random().Next(0, _prompts.Count);
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();

        // Prompt user to press enter when ready
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }    

    public void DisplayQuestions()
    {
        // List to store indexes of selected questions
        List<int> indexes = new List<int>();

        // Select 4 unique random questions
        for (int i = 0; i < 4; i++)
        {
            int randomInt = new Random().Next(0, _questions.Count);
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0, _questions.Count);
            }
            indexes.Add(randomInt);
        }

        // Clear the console and prompt user to ponder the questions
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();
        DisplayCountdown(5); // Display a countdown before showing questions

        // Display each selected question with a spinner
        foreach (int index in indexes)
        {
            Console.Write(_questions[index]);
            DisplaySpinner(GetUserSessionLengthInput() / indexes.Count);
            Console.WriteLine();
        }
    }
}
