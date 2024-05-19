using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        // Set the name and description of the activity
        SetActivityName("Breathing Activity");
        SetActivityDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunBreathingActivity()
    {
        // Start the activity with parent class methods
        RunActivityParentStart();
        DisplayInOut();
        RunActivityParentEnd();
    }

    public void DisplayInOut()
    {
        // Get the user's session length in seconds and convert it
        int time = GetUserSessionLengthInput() * 1000;
        int intervalTime = 10000;
        int intervals = time / intervalTime;
        
        // Loop through each interval
        for (int i = 0; i < intervals; i++)
        {
            // Perform breathing in for X seconds
            Console.Write("Breathe in... ");
            CountUp();
            Console.WriteLine();
            
            Console.Write("Breathe out... ");
            Countdown();
            Console.WriteLine();
        }
    }

    private void Countdown()
    {
        // Count down from 5 to 1
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            ClearCurrentConsoleLine();
        }
    }

    private void CountUp()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Wait for 1 second
            ClearCurrentConsoleLine();
        }
    }

    private void ClearCurrentConsoleLine()
    {
        // Clear the current line in the console
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }
}
