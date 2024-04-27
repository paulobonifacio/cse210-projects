using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101); //Get the random number and store it in the variable 

        Console.WriteLine("Welcome to the Guess the Magic Number game!");
        Console.WriteLine("I choose a magic number between 1 and 100. Try to guess it!");

        int guess;
        bool guessedCorrectly = false;
    
        //Get the gues value and compare with the internal number
        do
        {
            Console.Write("\nWhat is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                guessedCorrectly = true;
            }
        } while (!guessedCorrectly);
    }
}