using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlaylist
{
    public class SmsNotificationService : INotificationService
    {
        public void OnSongAdded(object? sender, SongAddedEventArgs e)
        {
            Console.WriteLine($"SMS: Song '{e.SongTitle}' added to the playlist.");
        }
    }
}
