using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_CSharp
{
    internal class PremiumPlayer : ISpotify
    {
        public string CurrentSong { get; set; }

        public void pause()
        {
            Console.WriteLine($"{CurrentSong} Song is Paused");
        }

        public void play()
        {
            Console.WriteLine($"{CurrentSong} Song is play");
        }

        public void PlaySong(string songName)
        {
           CurrentSong = songName;
            play();
        }

        public void resume()
        {
            Console.WriteLine($"{CurrentSong} Song is resumed");
        }

        public void shuffle()
        {
            Console.WriteLine($"{CurrentSong} Song is shuffle");
        }

        public void stop()
        {
            Console.WriteLine($"{CurrentSong} Song is stopped");
        }
    }
}
