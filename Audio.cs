using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Snake
{
    public static class Audio
    {
        public readonly static MediaPlayer GameOver = LoadAudio("snakedeathsound.mp3");
        public readonly static MediaPlayer EatFood = LoadAudio("eatfoodsound (2).mp3");
        public readonly static MediaPlayer Background = LoadAudio("SMO.mp3");

        public static object BGMusic { get; internal set; }

        private static MediaPlayer LoadAudio(string filename, double volume = 1, bool repeat = false, bool autoReset = true)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Assets/{filename}", UriKind.Relative));
            player.Volume = volume;

            if (autoReset)
            {
                player.MediaEnded += Player_MediaEnded;
            }

            if (repeat)
            {
                // player.MediaEnded += PlayerRepeat_MediaEnded;
            }
            return player;
        }

        private static void Player_MediaEnded(object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
        }

        //private static void Player_MediaEnded(object sender, EventArgs e)
        //{
        //MediaPlayer m = sender as MediaPlayer;
        //m.Position = new TimeSpan(0);
        // m.Play();
        //}


       
    }
}
