using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlaylist
{
    public class EmailNotificationService : INotificationService
    {
        public void OnSongAdded(object? sender, SongAddedEventArgs e)
        {
            Console.WriteLine($"Email: Song '{e.SongTitle}' added to the playlist.");
        }
    }
    
}
