using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // use constructors to cereate 3-4 videos


        Video vid1 = new Video("LWIAY", "Pewds", 1800);
        Video vid2 = new Video("Lethal Company", "CaptainSparklez2", 1200);
        Video vid3 = new Video("Gwimbly", "LIMC", 153);

        List<Video> videos = new List<Video>();
        videos.Add(vid1);
        videos.Add(vid2);
        videos.Add(vid3);

        // use constructirs to add 3-4 comments to each video.
        Comment comment1 = new Comment("Trash Panda", "Good vid!");
        Comment comment2 = new Comment("ericdoa", "The indusrial revolution and its consequences...");
        Comment comment3 = new Comment("Grimes", "Your honor, shut up. You wasn't even there");
        Comment comment4 = new Comment("starfall", "Lore-wise: the coilhead just looks funny");
        Comment comment5 = new Comment("aldn", "nUh uH! *disintegrates your hypothalimus*");
        Comment comment6 = new Comment("Charli C", "aNyONe sTilL lIstEnIng In 2024?");
        Comment comment7 = new Comment("Jye", "Classic unhinged content");
        Comment comment8 = new Comment("Ennio Morricone", "FNAF take");
        Comment comment9 = new Comment("Huron John", "Thanks Librarian");
        Comment comment10 = new Comment("Adan Diaz", "Certainly an Iconic figure");
        Comment comment11 = new Comment("Gus Dapperton", "What a thing! Man never Carries");


        vid1.comments = new List<Comment>();
        vid1.comments.Add(comment1);
        vid1.comments.Add(comment2);
        vid1.comments.Add(comment3);

        vid2.comments = new List<Comment>();
        vid2.comments.Add(comment4);
        vid2.comments.Add(comment5);
        vid2.comments.Add(comment6);
        vid2.comments.Add(comment7);

        vid3.comments = new List<Comment>();
        vid3.comments.Add(comment8);
        vid3.comments.Add(comment9);
        vid3.comments.Add(comment10);
        vid3.comments.Add(comment11);

        // Console.WriteLine("1800");
        // Console.WriteLine(vid1.DisplayLength());

        // Console.WriteLine("1200");
        // Console.WriteLine(vid2.DisplayLength());

        // Console.WriteLine("153");
        // Console.WriteLine(vid3.DisplayLength());

        // Iterate thhrough the list of videos and display

        int vidCounter = 0;
        foreach (Video video in videos)
        {
            vidCounter++;

            string vidLength = video.DisplayLength();
            string megaString = $"Video {vidCounter} is '{video.DisplayTitle()}' by {video.DisplayAuthor()} ({vidLength} seconds long) has {video.ReturnNumberOfComments()} comments. The Comments are: ";

            string miniString = video.DisplayComments();

            megaString = megaString + "\n" + miniString + "\n\n";

            Console.WriteLine(megaString);

        }

        // tite, Author, Length()seconds, number of comments, then list all comments
    }
}