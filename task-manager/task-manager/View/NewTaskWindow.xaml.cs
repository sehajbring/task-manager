using System.Windows;
using task_manager.ViewModel;

namespace task_manager.View
{

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
