using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class CD
    {
        public string Artist { get; set; }
        public double Price { get; set; }

        private List<Song> songlist;

        public CD()
        {
            songlist = new List<Song>();
        }
        public void AddTrack(Song song)
        {
            songlist.Add(song);
        }
        public override string ToString()
        {
            return "Artist:" + Artist + ", Price:" + Price + ", Songs:";
        }
        public void PrintSongMyBoi()
        {
            foreach (Song song in songlist)
            {
                Console.WriteLine(song.ToString());
            }

        }
        
    }
}
