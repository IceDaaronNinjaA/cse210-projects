using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video newVideo1 = new Video("Test1", "Testdescription1", 1);
        newVideo1.addComment("Test2", "Testdescription2");
        newVideo1.addComment("test3", "Testdescription3");
        newVideo1.addComment("Me", "First");
        videos.Add(newVideo1);
        Video newVideo2 = new Video("Test4", "Testdescription4", 1);
        newVideo2.addComment("Test5", "Testdescription5");
        newVideo2.addComment("Test6", "Testdescription6");
        newVideo2.addComment("Me", "First");
        videos.Add(newVideo2);
        Video newVideo3 = new Video("Test1", "Testdescription1", 1);
        newVideo3.addComment("Test2", "Testdescription2");
        newVideo3.addComment("test3", "Testdescription3");
        newVideo3.addComment("Me", "First");
        Video newVideo4 = new Video("Test1", "Testdescription1", 1);
        newVideo4.addComment("Test2", "Testdescription2");
        newVideo4.addComment("test3", "Testdescription3");
        newVideo4.addComment("Me", "First");
        foreach (Video video in videos)
        {
            video.displayVideoOnly();
            video.displayVideoPlusComments();
        }
        
    }
}