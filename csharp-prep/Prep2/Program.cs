using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine sign based on the percentage 
        char sign = ' ';
        if (percent % 10 == 3)
        {
            sign = '-';
        }

        // Check for special cases of A+ and A-
        if (letter == "A" && percent != 100 && sign == '+')
        {
            letter += '-';
        }
        else if (letter == "A" && percent != 100 && sign == ' ')
        {
            letter += '+';
        }
        else if (letter == "F" && sign != ' ')
        {
            letter = "F";
            sign = ' ';
        }

        // Check if passed and display the message
        if (percent >= 70)
        {
            Console.WriteLine($"Your grade is {letter}{sign}. Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}{sign}. Better luck next time!");
        }
    }
}
