using System;
using System.Collections.Generic;  

class Program
{
    static void Main(string[] args)
    {
        // Creating a list to store exercises
        List<Exercise> exerciseList = new List<Exercise>();
        
        // Creating a running exercise and adding to the list
        Running running = new Running("June 02, 2024", 90, 9.7);
        exerciseList.Add(running);

        // Creating a stationary bicycles exercise and adding to the list
        StationaryBicycles stationaryBicycles = new StationaryBicycles("May 05, 2024", 45, 10);
        exerciseList.Add(stationaryBicycles);

        // Creating a swimming exercise and adding to the list
        Swimming swimming = new Swimming("April 17, 2024", 30, 12);
        exerciseList.Add(swimming);

        // Displaying the exercises
        Console.WriteLine("Exercises:");
        Console.WriteLine();

        // Loop through each exercise in the list and print its summary
        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}
