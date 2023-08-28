using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface_CSharp
{
   public class MusicPlayerController
    {
        public void UsePlayer(ISpotify player)
        {
            Console.WriteLine("Using Spotify");
            player.PlaySong("The Wolf by The Siames");
            player.pause();
            player.stop();
            player.resume();
        }
    }
}
