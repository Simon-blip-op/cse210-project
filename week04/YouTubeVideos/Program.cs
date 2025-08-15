using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Intro to C#", "Simon", 300);
        Video video2 = new Video("OOP in Real Life", "Jimmy", 450);
        Video video3 = new Video("Abstraction Explained", "Eliza", 500);


        Viewer viewer1 = new Viewer("Zoe");
        Viewer viewer2 = new Viewer("Mark");
        Viewer viewer3 = new Viewer("Nina");


        viewer1.WatchVideo(video1);
        viewer2.WatchVideo(video1);
        viewer3.WatchVideo(video1);
        viewer1.WatchVideo(video2);
        viewer3.WatchVideo(video3);


        viewer1.LeaveComment(video1, "Great explanation!");
        viewer2.LeaveComment(video1, "Very helpful.");
        viewer3.LeaveComment(video1, "I finally understand C# now.");

        viewer1.LeaveComment(video2, "Thanks for this!");
        viewer2.LeaveComment(video2, "Loved it!");
        viewer3.LeaveComment(video2, "This helped me to understand OOP much better");

        viewer1.LeaveComment(video3, "One of the best explainations I've seen!  ");
        viewer2.LeaveComment(video3, "This really cleared up my confusion about abstraction. . ");
        viewer3.LeaveComment(video3, "I like how you explained the this, step by step. Amazing! ");


        Console.WriteLine(video1.GetDisplayString());
        Console.WriteLine();
        Console.WriteLine(video2.GetDisplayString());
        Console.WriteLine();
        Console.WriteLine(video3.GetDisplayString());
        Console.WriteLine();


        Console.WriteLine(viewer1.GetDisplayString());
        Console.WriteLine(viewer2.GetDisplayString());
        Console.WriteLine(viewer3.GetDisplayString());
    }
}