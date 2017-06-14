using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        // field
        private List<Track> tracks { get; set; } = new List<Track>();

        // initialized property
        public List<Track> Tracks { get { return tracks; } }

        // initializing list as new list object
        // private List<string> tracks = new List<string>();

        // auto-implemented property
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }

        // methods
        public void AddTrack(Track track)
        {
            tracks.Add(track);
        }

        public TimeSpan GetPlayingTime()
        {
            // initiate new time span time line
            TimeSpan total = new TimeSpan();

            foreach (Track track in tracks)
            {
                // total is equal to total plus the length
                // so everytime total will be equal to the next calculation
                total = total + track.Length;
            }

            return total;
        }

        // constructors
        public MusicCD()
        {

        }

        public MusicCD(int productId, string title, decimal price, string imageUrl, string artist, string label, short released) : base(productId, title, price, imageUrl)
        {
            Artist = artist;
            Label = label;
            Released = released;
        }
    }
}