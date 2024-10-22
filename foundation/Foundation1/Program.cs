using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        // Video 1
        Video video1 = new Video("deleting this video in 24 hours...", "Kelly Wakasa", 769);

        Comment v1c1 = new Comment("ChrisJammaers", "Yes, I saw you talk about this on the podcast and was hoping you would post it!");
        Comment v1c2 = new Comment("michaelhancock9058", "I saw Ashley encourage you to post this on the podcast I love it! So happy to see yall building each other up!");
        Comment v1c3 = new Comment("CNoel", "Don't delete it Kelly!  Can't believe you almost didn't post it at all.");

        video1.AddComment(v1c1);
        video1.AddComment(v1c2);
        video1.AddComment(v1c3);

        videoList.Add(video1);

        // Video 2
        Video video2 = new Video("The Heart of the Gospel: Love God and Neighbor", "The Church of Jesus Christ of Latter-day Saints", 168);

        Comment v2c1 = new Comment("guardianangel9517", "We all need to remember this. Thank you so much");
        Comment v2c2 = new Comment("FredricaSere", "Thank you very much elder Stevenson for the great message I've heard this morning");
        Comment v2c3 = new Comment("JessiBarcarsy", "Thank you Jesus Christ and Elder Stevenson love the lord");
        Comment v2c4 = new Comment("adareed1803", "Thank you so much for this wonderful message.");

        video2.AddComment(v2c1);
        video2.AddComment(v2c2);
        video2.AddComment(v2c3);
        video2.AddComment(v2c4);

        videoList.Add(video2);

        // Video 3
        Video video3 = new Video("The Best Of 2024 (so far)", "Daily Dose Of Internet", 646);

        Comment v3c1 = new Comment("DKeigo", "Love the recap. I forgot about some of these gems.");
        Comment v3c2 = new Comment("xerty_2865", "I thought it was the end of the year for a second");
        Comment v3c3 = new Comment("GioCastillo-f8r", "dogs are very silly");

        video3.AddComment(v3c1);
        video3.AddComment(v3c2);
        video3.AddComment(v3c3);

        videoList.Add(video3);

        // Display all
        foreach (Video video in videoList)
        {
            video.Display();
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}