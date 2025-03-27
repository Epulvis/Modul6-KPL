using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title.Length < 201, "Judul video tidak boleh melebihi 200 karakter");
            Debug.Assert(!string.IsNullOrEmpty(title), "Judul video tidak berupa null");
            Random random = new Random();
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count > 0 && count <= 25000000, "Penambahan play count harus antara 1 Hingga 25.000.000");
            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas!");
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
