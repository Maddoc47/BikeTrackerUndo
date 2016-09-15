using System.Collections.Generic;
using System.Windows.Documents;
using GalaSoft.MvvmLight;
using BikeTrack_UndoRedo_01.Model;
using BikeTrack_UndoRedo_01.Services;

namespace BikeTrack_UndoRedo_01.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public List<TrackItem> Tracks { get; set; }
        
        private string _welcomeTitle = "BikeTracker";

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            Tracks = new List<TrackItem>();

            GetTracks();
        }

        public void GetTracks()
        {
            var track1 = _dataService.GetTrackItem("Antwerp", 10.50f, 33);
            var track2 = _dataService.GetTrackItem("Hove", 12.34f, 42);
            Tracks.Add(track1);
            Tracks.Add(track2);
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}