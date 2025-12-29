using System;
using System.Collections.Generic;
using System.Text;
using MusicPlaylist;
using MusicPlayList;

namespace MusicPlaylist
{
    public class SmsNotificationService
    {
        public void OnSongAdded(object? sender, SongAddedEventArgs e)
        {
            Console.WriteLine($"SMS: Song '{e.SongTitle}' added to the playlist.");
        }
    }
}
