using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>(); // List to store video objects

        // Creating the first video and adding comments
        Video video1 = new Video("FLYING OVER SWITZERLAND (4K UHD) - Relaxing Music With Stunning Beautiful Nature (4K Video Ultra HD)", "Earth Relaxation ", 480);

        // Adding comments to the first video
        Comment video1Comment1 = new Comment("Luiz", "I love this video and my dream is to be able to travel all over Switzerland one day..");
        Comment video1Comment2 = new Comment("Micharia", "I can imagine paradise through the landscapes in Switzerland, thank you for sharing.");
        Comment video1Comment3 = new Comment("Fofoquinha", "Wonderful.");

        // Adding comments to the list of comments in video1
        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        // Adding the first video to the list of videos
        videosList.Add(video1);

        // Creating the second video and adding comments
        Video video2 = new Video("10 Most Beautiful Places To Visit in Italy ", "Lifestyle Hal", 970);

        // Adding comments to the second video
        Comment video2Comment1 = new Comment("Paulo", "What a magical place. I love seeing the beautiful cities and landscapes of Italy, my heart beats.");
        Comment video2Comment2 = new Comment("Fatima", "Traveling to Italy tomorrow!!!.");
        Comment video2Comment3 = new Comment("Lia", "My grandparents are Italian and they were so happy to see these videos.");

        // Adding comments to the list of comments in video2
        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        // Adding the second video to the list of videos
        videosList.Add(video2);

        // Creating the third video and adding comments
        Video video3 = new Video("Quebec, la ville inatenndue", "TF1 INFO", 650);

        // Adding comments to the third video
        Comment video3Comment1 = new Comment("Alessandra", "J'aime la ville de Québec.");
        Comment video3Comment2 = new Comment("Maria", "Mon village depuis 10 ans, la neige et les moments magiques me manquent.");
        Comment video3Comment3 = new Comment("Cleitin", "Vive le Québec !!!");

        // Adding comments to the list of comments in video3
        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        // Adding the third video to the list of videos
        videosList.Add(video3);

        // Displaying information for each video
        foreach (Video video in videosList)
        {
            video.DisplayInfo(); // Displaying video info and comments
            Console.WriteLine(); // Adding a blank line for separation
            Console.WriteLine(); // Adding another blank line for better readability
        }
    }
}