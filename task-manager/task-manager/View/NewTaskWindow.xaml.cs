using System.Windows;
using task_manager.ViewModel;

namespace task_manager.View
{
    /***
     * Main Driver for the new task window window.
     * Initalizes the appropriate Veiw model class as per the MVVM design principle
     * and connects it to the UI.
     * 
     */
    public partial class NewTaskWindow : Window
    {
        public NewTaskWindow(System.Collections.ObjectModel.ObservableCollection<Model.Task> tasks)
        {
            InitializeComponent();
            NewTaskWindowViewModel viewModel = new NewTaskWindowViewModel(tasks);
            this.DataContext = viewModel;
        }

    }
}
