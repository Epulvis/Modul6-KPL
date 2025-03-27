using System;
using System.Collections.Generic;
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
              sum += uploadedVideos[i].playCount;
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
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i+1} judul: {uploadedVideos[i].title} ");
            }
        }
    }
}
