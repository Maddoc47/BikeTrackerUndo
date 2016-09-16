using System;
using System.ComponentModel;

namespace BikeTrack_UndoRedo_01.Model
{
    internal class TrackItem
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public float Length { get; set; }

        public int Time { get; set; }

        private float _timePerKm;
        public float TimePerKm
        {
            get
            {
                if (!Length.Equals(0))
                {
                    return Time/Length;
                }
                return 0;
            }
            set
            {
                if (!Length.Equals(0))
                {
                    value = Time / Length;
                    _timePerKm = value;
                }
            }
        }
        public TrackItem() { }
    }
}