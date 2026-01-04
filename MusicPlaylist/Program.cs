using MusicPlaylist;
using System;
using System.Collections.Generic;
using System.Text;


namespace MusicPlayList
{

    public class MusicPlayList
    {
        private List<string> _songs = new List<string>();

        public event EventHandler<SongAddedEventArgs>? SongAdded;


        protected virtual void OnSongAdded(SongAddedEventArgs e)
        {
            SongAdded?.Invoke(this, e);

        }
        public void AddSong(string song)
        {
            ValidateSong(song);
            _songs.Add(song);
            OnSongAdded(new SongAddedEventArgs(song));
        }

        private void ValidateSong(string song)
        {
            if (string.IsNullOrWhiteSpace(song))
            {
                throw new ArgumentException("Song title cannot be null or empty.", nameof(song));
            }
        }

        public static void Main()
        {
            MusicPlayList playList = new MusicPlayList();
            SmsNotificationService smsService = new SmsNotificationService();
            EmailNotificationService emailService = new EmailNotificationService();

            playList.SongAdded += smsService.OnSongAdded;
            playList.SongAdded += emailService.OnSongAdded;

            playList.AddSong("Song Title.... ");
            playList.AddSong("Another Song Title... ");
            playList.AddSong(" ");

        }

    }
}