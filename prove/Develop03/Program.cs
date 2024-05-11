using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference to a scripture
        Reference scriptureReference = new Reference("Proverbs", "3", "5-6");
        // Create a scripture object with the reference and text
        Scripture scripture = new Scripture(scriptureReference, "Trust in the lord with all thine heart and understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        // Create a scripture memo object with the scripture
        ScriptureMemo scriptureMemo = new ScriptureMemo(scripture);

        string userInput = "";

        // Loop until the user inputs "quit" or all words are memorized
        while (userInput != "quit" && scriptureMemo.hasWordsLeft() == true)
        {
            Console.Clear();
            // Display scripture reference and remaining words to memorize
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemo.toString()));
            Console.WriteLine();

            // Get user input
            userInput = Console.ReadLine();
            // Remove words from scripture text
            scriptureMemo.removeWordsFromText();
        }

        Console.Clear();
        // Display scripture reference and remaining words to memorize
        Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemo.toString()));
        Console.WriteLine();
        
        // Display message upon completion
        Console.WriteLine("Excellent!!!");
    }
}
