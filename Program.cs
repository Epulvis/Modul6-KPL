﻿using modul6_103022300057;

internal class Program
{
    private static void Main(string[] args)
    {
        //Test User berisi Null
        SayaTubeUser UserTest = new("");

        //Test User berisi lebih dari 200 karakter
        SayaTubeVideo UserTest2 = new (new string('A', 201));

        SayaTubeUser User = new("zuhri");
        SayaTubeVideo Video1 = new("Review Film TelU 1 oleh Zuhri");
        SayaTubeVideo Video2 = new("Review Film TelU 2 oleh Zuhri");
        SayaTubeVideo Video3 = new("Review Film TelU 3 oleh Zuhri");
        SayaTubeVideo Video4 = new("Review Film TelU 4 oleh Zuhri");
        SayaTubeVideo Video5 = new("Review Film TelU 5 oleh Zuhri");
        SayaTubeVideo Video6 = new("Review Film TelU 6 oleh Zuhri");
        SayaTubeVideo Video7 = new("Review Film TelU 7 oleh Zuhri");
        SayaTubeVideo Video8 = new("Review Film TelU 8 oleh Zuhri");
        SayaTubeVideo Video9 = new("Review Film TelU 9 oleh Zuhri");
        SayaTubeVideo Video10 = new("Review Film TelU 10 oleh Zuhri");

        //Test pemambahan Video berisi Null
        try
        {
            User.AddVideo();
        } catch
        {
            Console.WriteLine("Video Tidak Boleh berisi Null");
        }

        //tesr overflow
        for (int i = 0; i < 100; i++)
        {
            Video1.IncreasePlayCount(10000000);
        }


        Video1.IncreasePlayCount(50);
        Video1.PrintVideoDetails();

        User.AddVideo(Video1);
        User.AddVideo(Video2);
        User.AddVideo(Video3);
        User.AddVideo(Video4);
        User.AddVideo(Video5);
        User.AddVideo(Video6);
        User.AddVideo(Video7);
        User.AddVideo(Video8);
        User.AddVideo(Video9);
        User.AddVideo(Video10);

        User.GetTotalVideoPlayCount();

        User.PrintAllVideoPlaycount();
    }
}