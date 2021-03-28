using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Basic
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string aName, string aArtist, int aDuration)
        {
            title = aName;
            artist = aArtist;
            duration = aDuration;
            songCount += 1;
        }
    }
}
