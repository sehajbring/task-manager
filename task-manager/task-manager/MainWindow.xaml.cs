using System.Windows;
using System.Windows.Controls;
using TaskManager.ViewModel;

namespace task_manager
{
    /***
     * Main Driver for the main window.
     * Initalizes the appropriate Veiw model class as per the MVVM design principle
     * and connects it to the UI.
     * 
     */
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel viewModel = new MainWindowViewModel();
            DataContext = viewModel;
        }

    }
}