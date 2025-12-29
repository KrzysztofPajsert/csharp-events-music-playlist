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
                throw new ArgumentNullException("Song title cannot be null.");
            }
        }



        private static void SendSMSAddSong()
        {
            Console.WriteLine("SMS: Song added to the playlist.");
        }

        public static void Main()
        {
            MusicPlayList playList = new MusicPlayList();
            SmsNotificationService smsService = new SmsNotificationService();

            playList.SongAdded += smsService.OnSongAdded;

            playList.AddSong("Song 1");
            //playList.AddSong(null);

        }

    }
}