using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
       Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        // Sum the values.
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate the average.
        double average = (double)sum / numbers.Count;

        // Identify the maximum number.
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Show the Output messages.
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }
}