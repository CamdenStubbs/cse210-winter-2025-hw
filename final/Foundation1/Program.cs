using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Comment sealComment1 = new Comment("Dani-Guy", "That seal is so cute!");
        Comment sealComment2 = new Comment("Contraaron", "Overrated video tbh");
        Comment sealComment3 = new Comment("cutelilguy", "<3 lovely");

        Video sealVideo = new Video("WHOAAAA SEEAAALLLLSSS!", "ILOVESEALS", 354);

        sealVideo.AppendComment(sealComment1);
        sealVideo.AppendComment(sealComment2);
        sealVideo.AppendComment(sealComment3);

        videos.Add(sealVideo);

        Comment popularComment1 = new Comment("lilTimTim", "haha funny");
        Comment popularComment2 = new Comment("loyal-influencer-fan123", "I love all the high-quality content here!");
        Comment popularComment3 = new Comment("Contraaron", "Don't fall for the slop! It's for the algorithm!");
        Comment popularComment4 = new Comment("noTh0ughtsh3AdEmpty", "is the video of all time");

        Video popularVideo = new Video("I made a title so YOU would click on this video", "Generic24/7", 605);

        popularVideo.AppendComment(popularComment1);
        popularVideo.AppendComment(popularComment2);
        popularVideo.AppendComment(popularComment3);
        popularVideo.AppendComment(popularComment4);

        videos.Add(popularVideo);

        Comment controvesyComment1 = new Comment("lilTimTim", "first");
        Comment controvesyComment2 = new Comment("defenderbender", "So fake oh my");
        Comment controvesyComment3 = new Comment("imabeliever", "can't believe the drama is tru");
        Comment controvesyComment4 = new Comment("Contraaron", "Only true and accurate video I love fake drama");

        Video controvesyVideo = new Video("Fake drama against Generic24/7", "NotTheBestGuy", 609);

        controvesyVideo.AppendComment(controvesyComment1);
        controvesyVideo.AppendComment(controvesyComment2);
        controvesyVideo.AppendComment(controvesyComment3);
        controvesyVideo.AppendComment(controvesyComment4);

        videos.Add(controvesyVideo);

        DisplayAllVideos(videos);
    }

    static void DisplayAllVideos(List<Video> videos)
    {
        int i = 1;
        foreach (Video video in videos)
        {
            Console.WriteLine($"________\nVIDEO {i}");
            video.Display();
            i++;
        }
    }
}