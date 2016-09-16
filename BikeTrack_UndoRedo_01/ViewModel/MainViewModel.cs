using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using GalaSoft.MvvmLight;
using BikeTrack_UndoRedo_01.Model;
using BikeTrack_UndoRedo_01.Services;
using GalaSoft.MvvmLight.Command;


namespace BikeTrack_UndoRedo_01.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    internal class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            TrackCollection = new ObservableCollection<TrackItem>();
        }
        
        public string WelcomeTitle { get; set; } = "Biketracker";
        public ObservableCollection<TrackItem> TrackCollection { get; set; }

        
        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}