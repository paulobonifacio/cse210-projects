using System;

public class Entry 
{
    public string _prompt;
    public string _response;
    public string _date;

    public void GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void GeneratePrompt()
    {
        List<string> prompts = new List<string>()
        {
                "Did anything unexpected happen today that surprised you? ",
                "What was the most challenging thing you faced today and how did you overcome it? ",
                "What was the best moment of your day and why? ",
                "Who did you share a special moment with today? ",
                "Did you discover anything new or learn something interesting today? ",
                "Did someone make you feel special or make you smile today?" ,
                "Did you achieve any success in your work, studies or personal projects today? ",
                "Did you do anything today that took you out of your comfort zone? ",
                "What would you like to do more of in your daily life and how do you plan to achieve it? ",
                "What do you most wish for tomorrow? ",
                "How did you show love or compassion towards others today, inspired by your faith? ",
        };

        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        Console.WriteLine(_prompt);
    }

    public void GetResponse()
    {
        Console.Write("> ");
        _response = Console.ReadLine();
    }
}