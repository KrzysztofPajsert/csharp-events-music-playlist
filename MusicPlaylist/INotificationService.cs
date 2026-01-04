using System;
using System.Collections.Generic;
using System.Text;
using MusicPlaylist;
using MusicPlayList;

namespace MusicPlaylist
{
   
    public interface INotificationService
    {
        void OnSongAdded(object? sender, SongAddedEventArgs e);
    }   


}
