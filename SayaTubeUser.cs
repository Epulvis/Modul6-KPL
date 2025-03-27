using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300057
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string Username)
        {
            Debug.Assert(Username.Length < 101, "Username tidak boleh melebihi 100 karakter");
            Debug.Assert(!string.IsNullOrEmpty(Username), "Username tidak berupa null");
            Random random = new Random();
            this.Username = Username;
            this.id = random.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
        }
        
        public int GetTotalVideoPlayCount()
        {
            int sum = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Debug.Assert(sum <= 999999999, "Melebihi limit int");
                try
                {
                    checked
                    {
                        sum += uploadedVideos[i].playCount;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Play count melebihi batas!");
                }
            }
            return sum;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Video {i+1} judul: {uploadedVideos[i].title} ");
            }
        }

        public void AddVideo()
        {
            throw new ArgumentNullException();
        }
    }
}
