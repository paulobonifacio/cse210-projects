using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating address for the first event
        Address address = new Address("Avenida Paulista", "SP", "SP", "Brazil");

        // Creating a lecture event
        Lecture lecture = new Lecture("Literary Reading: 'The operator'", "Secret War", "May 05, 2019", "9 AM", address, "Rafaela Geovana", 120);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        
        // Generating and displaying standard lecture information
        Console.WriteLine(lecture.GenerateStandard());
        Console.WriteLine();
        
        // Generating and displaying detailed lecture information
        Console.WriteLine(lecture.GenerateDetailedLecture());
        Console.WriteLine();
        
        // Generating and displaying short lecture information
        Console.WriteLine(lecture.GenerateShortLecture());

        // Creating address for the second event
        Address addressR = new Address("565", "Rue du Parvis", "Quebec", "Canada");

        // Creating a reception event
        Reception reception = new Reception("Open discussion about Jesus Christ", "Temple meeting with the Bishops", "Novembre 10, 2024", "6 PM", addressR, "openevents@ourchurch.com");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        
        // Generating and displaying standard reception information
        Console.WriteLine(reception.GenerateStandard());
        Console.WriteLine();
        
        // Generating and displaying detailed reception information
        Console.WriteLine(reception.GenerateDetailedReception());
        Console.WriteLine();
        
        // Generating and displaying short reception information
        Console.WriteLine(reception.GenerateShortReception());

        // Creating address for the third event
        Address addressOG = new Address("Plainpalais", "Geneva", "Geneva", "Switzerland");

        // Creating an outdoor gathering event
        OutdoorGathering outdoorGathering = new OutdoorGathering("Cirque Food Truck and Music", "Summer Party", "Juin 02, 2024", "1 PM", addressOG, "Summer");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");
        Console.WriteLine();
        
        // Generating and displaying standard outdoor gathering information
        Console.WriteLine(outdoorGathering.GenerateStandard());
        Console.WriteLine();
        
        // Generating and displaying detailed outdoor gathering information
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());
        Console.WriteLine();
        
        // Generating and displaying short outdoor gathering information
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}
