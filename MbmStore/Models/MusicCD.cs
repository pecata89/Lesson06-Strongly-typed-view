using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using MbmStore.DAL;

namespace MbmStore.Models
{
    [Table("MusicCD")]
    public class MusicCD : Product
    {
        // field
        private List<Track> tracks = new List<Track>();

        // auto-implemented property
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public Track Track { get; set; }

        // initialized property
        public ICollection<Track> Tracks
        {
            get
            {
                return tracks;
            }
            set
            {
                tracks = value.ToList();
            }
        }

        // methods
        //public void AddTrack(Track track)
        //{
        //    Tracks.Add(track);
        //}
        // initializing list as new list object
        // private List<string> tracks = new List<string>();
        
        // constructors
        public MusicCD()
        {

        }

        public MusicCD(string artist, string title, decimal price, short released) : base(title, price)
        {
            Artist = artist;
            Released = released;
        }

        public TimeSpan GetPlayingTime()
        {
            // initiate new time span time line
            //TimeSpan total = TimeSpan.Parse("00:00");
            TimeSpan total = new TimeSpan();

            foreach (Track track in Tracks)
            {
                // total is equal to total plus the length
                // so everytime total will be equal to the next calculation
                total += track.Length;
            }

            return total;
        }
    }
}