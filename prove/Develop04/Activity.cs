using System;
using System.Diagnostics;
using System.Threading;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _activityDescription;
    private string _activityName;
    static int _spinnerCounter = 0;
    static int _userSessionLengthInput = 0;

    public Activity()
    {
        // Initialize spinner counter and session length input
        _spinnerCounter = _userSessionLengthInput = 0;
    }

    public void SetActivityName(string activityName)
    {
        // Set the name of the activity
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        // Set the description of the activity
        _activityDescription = activityDescription;
    }

    public int GetUserSessionLengthInput()
    {
        // Get the length of the user session
        return _userSessionLengthInput;
    }
    public void DisplayStartingtMessage()
    {
        // Display the starting message
        _startingMessage = $"Welcome to the {_activityName}.";
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        // Display the description of the activity
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        // Display the ending message
        _endingMessage = $"You have complete {_userSessionLengthInput} seconds of the {_activityName}.";
        Console.WriteLine();
        Console.WriteLine("Well done!");
        DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(_endingMessage);
        DisplaySpinner(5);
        Console.Clear();
    }

    public void DisplaySpinner(int numSecondsToRun)
    {
        // Display a spinner animation for the given number of seconds
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }

            // Ensure the cursor position is not set to a negative value
            if (Console.CursorLeft > 0)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            else
            {
                // If CursorLeft is zero, just reset to the start of the line
                Console.SetCursorPosition(0, Console.CursorTop);
            }

            Thread.Sleep(200);
        }

        // Clear the spinner
        Console.Write(" ");
    }

    public void DisplayCountdown(int numSecondsToRun)
    {
        // Display a countdown before starting the activity
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Console.Write($" You may begin in: {i} ");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void DisplayGetSessionLength()
    {
        // Prompt the user to enter the session length
        Console.Write("How long, in seconds, would you like for your session? ");
        _userSessionLengthInput = int.Parse(Console.ReadLine());
    }

    public void DisplayGetReady()
    {
        // Display a "Get ready" message with a spinner
        Console.WriteLine("Get ready...");
        DisplaySpinner(5);
    }

    public void RunActivityParentStart()
    {
        // Run the start sequence of the activity
        DisplayStartingtMessage();
        DisplayDescription();
        DisplayGetSessionLength();
        DisplayGetReady();
        Console.Clear();
    }

    public void RunActivityParentEnd()
    {
        // Run the end sequence of the activity
        DisplayEndingMessage();
    }
}
