using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using GalaSoft.MvvmLight;
using BikeTrack_UndoRedo_01.Model;
using BikeTrack_UndoRedo_01.Services;
using GalaSoft.MvvmLight.Command;
using Memento;

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
        private readonly Mementor _mementor;
        

        public MainViewModel(IDataService dataService, Mementor mementor)
        {
            _dataService = dataService;
            _mementor = mementor;
            TrackCollection = new ObservableCollection<TrackItem>();

            UndoCommand = new RelayCommand(OnUndo);
        }
        
        public string WelcomeTitle { get; set; } = "Biketracker";
        public ObservableCollection<TrackItem> TrackCollection { get; set; }


        //RelayCommands are created in the ViewModels
        public RelayCommand UndoCommand { get; set; }
        


        private void OnUndo()
        {
            _mementor.Undo();
            UndoCommand.RaiseCanExecuteChanged();
        }
        


        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}