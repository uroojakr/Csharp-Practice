using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_CSharp
{
    public interface ISpotify
    {
        void play();
        void resume();
        void pause();
        void stop();
        

        string CurrentSong { get; set; }
        void PlaySong(string songName);
    }
}