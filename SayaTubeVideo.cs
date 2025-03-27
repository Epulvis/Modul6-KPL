using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300057
{
    class SayaTubeVideo
    {
        private int id;
        public string title;
        public int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }

    }
}
