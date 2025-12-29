using System;
using System.Collections.Generic;
using System.Text;
using MusicPlaylist;


namespace MusicPlaylist
{
    public class SongAddedEventArgs : EventArgs
    {
        public string SongTitle { get; }
        public SongAddedEventArgs(string songTitle)
        {
            SongTitle = songTitle;
        }
    }
}
