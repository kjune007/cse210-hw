using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        //Creating first video variables
        string videoName1 = "Tips For More Effective Study";
        string authorName1 = "Studyman1";
        int videoLength = 257;
        
        string commentAuthor1 = "RandomGuy27";
        string commentText1 = "Great Video! I will use these study tips!";

        string commentAuthor2 = "RandomChick15";
        string commentText2 = "I already do all these things in this video... Lame";

        string commentAuthor3 = "FatMan3000";
        string commentText3 = "I agree these tips will help anyone learn more effectively";

        //Creating first Video
        Video Video1 = new Video();
        Video1.SetVideoInfo(videoName1,authorName1,videoLength);
        
        Comment Comment1 = new Comment();
        Comment Comment2 = new Comment();
        Comment Comment3 = new Comment();
        
        Comment1.SetCommentInfo(commentAuthor1,commentText1);
        Comment2.SetCommentInfo(commentAuthor2,commentText2);
        Comment3.SetCommentInfo(commentAuthor3,commentText3);

        Video1.AddComments(Comment1);
        Video1.AddComments(Comment2);
        Video1.AddComments(Comment3);
    

        //Creating second video varables
        string videoName2 = "Tips For A Healthier Lifestyle";
        string authorName2 = "Fitman1";
        int videoLength2 = 327;
        
        string commentAuthor21 = "FitGuy27";
        string commentText21 = "Great Video! I will use these Fitness tips!";

        string commentAuthor22 = "freakyChick15";
        string commentText22 = "decent health tips";

        string commentAuthor23 = "FatMan3000";
        string commentText23 = "naaahh... I weigh 600 lbs and I feel fine.";

        //Creating Second Video
        Video Video2 = new Video();
        Video2.SetVideoInfo(videoName2,authorName2,videoLength2);
        
        Comment Comment21 = new Comment();
        Comment Comment22 = new Comment();
        Comment Comment23 = new Comment();
        
        Comment21.SetCommentInfo(commentAuthor21,commentText21);
        Comment22.SetCommentInfo(commentAuthor22,commentText22);
        Comment23.SetCommentInfo(commentAuthor23,commentText23);

        Video2.AddComments(Comment21);
        Video2.AddComments(Comment22);
        Video2.AddComments(Comment23);

        //Creating third video varables
        string videoName3 = "How to Learn Programming";
        string authorName3 = "computerMan12";
        int videoLength3 = 451;
        
        string commentAuthor31 = "Someone27";
        string commentText31 = "Great Video! I will use these programming tips!";

        string commentAuthor32 = "RandomChick15";
        string commentText32 = "I already do all these things in this video... Lame";

        string commentAuthor33 = "FatMan3000";
        string commentText33 = "I agree these tips will help anyone learn  programming more effectively";

        //Creating third Video
        Video Video3 = new Video();
        Video3.SetVideoInfo(videoName3,authorName3,videoLength3);
        
        Comment Comment31 = new Comment();
        Comment Comment32 = new Comment();
        Comment Comment33 = new Comment();
        
        Comment31.SetCommentInfo(commentAuthor31,commentText31);
        Comment32.SetCommentInfo(commentAuthor32,commentText32);
        Comment33.SetCommentInfo(commentAuthor33,commentText33);

        Video3.AddComments(Comment31);
        Video3.AddComments(Comment32);
        Video3.AddComments(Comment33);

        Video1.SetNumberOfComments();
        Video2.SetNumberOfComments();
        Video3.SetNumberOfComments();

        //Showing user creating videos
        Console.WriteLine("Creating Videos...");
        Thread.Sleep(1000);
        Console.WriteLine("Videos Created");
        Thread.Sleep(1000);
        Console.Clear();

        string Video1Info = Video1.GetVideoInfo();
        string Video2Info = Video2.GetVideoInfo();
        string Video3Info = Video3.GetVideoInfo();
        
        List<Comment>_commentsForVideo1 =  Video1.GetComments();
        List<Comment>_commentsForVideo2 =  Video2.GetComments();
        List<Comment>_commentsForVideo3 =  Video3.GetComments();

        //Displaying video info
        Console.WriteLine(Video1Info);

        foreach (Comment comment in _commentsForVideo1)
        {
            string _commentInfo = comment.GetComment();
            Console.WriteLine($"{_commentInfo}");
        }

        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine(Video2Info);

        foreach (Comment comment in _commentsForVideo2)
        {
            string _commentInfo = comment.GetComment();
            Console.WriteLine($"{_commentInfo}");
        }

        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine(Video3Info);

        foreach (Comment comment in _commentsForVideo3)
        {
            string _commentInfo = comment.GetComment();
            Console.WriteLine($"{_commentInfo}");
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}