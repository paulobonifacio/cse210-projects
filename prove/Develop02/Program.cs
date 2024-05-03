using System;

/* Exceeding requirements */

class Program {
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do now? ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {   
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;
                case 2:
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Please enter the file name you want to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadEntries(loadFileName);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Please enter the file name you want to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveEntries(saveFileName);
                    Console.WriteLine("Saved!");
                    Console.WriteLine();
                    break;
                case 5:
                    running = false;
                    Console.WriteLine("Thanks and have a nice day!!!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please choose one of the following choices.");
                    break;
            }
        }
    }
}