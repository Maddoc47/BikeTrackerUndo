using BikeTrack_UndoRedo_01.Model;

namespace BikeTrack_UndoRedo_01.Services
{
    public interface IDataService
    {
        TrackItem GetTrackItem(string location, float length, int time);
    }
}
