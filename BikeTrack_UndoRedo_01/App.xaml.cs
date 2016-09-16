using System.Windows;
using BikeTrack_UndoRedo_01.ViewModel;
using GalaSoft.MvvmLight.Threading;

namespace BikeTrack_UndoRedo_01
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }

        private void App_OnStartup_(object sender, StartupEventArgs e)
        {
            var viewModelLocator = new ViewModelLocator();
            var mainView = new MainView()
            {
                DataContext = viewModelLocator.Main       
            };
            mainView.Show();
        }
    }
}
