using BikeTrack_UndoRedo_01.Model;

namespace BikeTrack_UndoRedo_01.Services
{
    public class DataService : IDataService
    {
        public TrackItem GetTrackItem(string location, float length, int time)
        {
            var track = new TrackItem(location, length, time);
            return track;

        }
    }
}
