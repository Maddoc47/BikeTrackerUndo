using System.ComponentModel;

namespace BikeTrack_UndoRedo_01.Model
{
    public class TrackItem
    {
        public string Location { get; set; }

        public float Length { get; set; }

        public int Time { get; set; }

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
        }

        public TrackItem(string location, float length, int time)
        {
            Location = location;
            Length = length;
            Time = time;
        }
    }
}