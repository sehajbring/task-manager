using System.Collections.ObjectModel;
using task_manager.MVVM;
using task_manager.Model;
using Task = task_manager.Model.Task;
using task_manager.View;

namespace TaskManager.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {

        public RelayCommand AddTaskCommand => new RelayCommand(execute => AddTask());
        public RelayCommand SaveNewTaskCommand => new RelayCommand(execute => SaveTask());
        public RelayCommand DeleteTaskCommand => new RelayCommand(execute => DeleteTask());

        private void SaveTask()
        {
        }

        public ObservableCollection<Task> Tasks { get; set; }
        private string displayCurrentDate;
        private Task selectedTask;
        public MainWindowViewModel() {
            TaskSupervisor taskSupervisor = new TaskSupervisor();
            Tasks = taskSupervisor.GetTasks();
            displayCurrentDate = DisplayCurrentDate();
        }

        public Task SelectedTask {  
            get { return selectedTask; } 
            set { 
                selectedTask = value;
                OnPropertyChanged();
            }
        }

        public string CurrentDate
        {
            get { return displayCurrentDate; }
        }

        private string DisplayCurrentDate()
        {
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Format the date as a string
            string formattedDate = currentDate.ToShortDateString();

            // Set the TextBlock's content
            return formattedDate;
        }

        // Deletes the currently selected task from the list
        private void DeleteTask()
        {
            //Check to see if there is a task currently selected
            if (SelectedTask != null)
            {
                //Remove currently selected task
                Tasks.Remove(SelectedTask);
            }
        }

        //Initiates a new Window will the user can create a new task
        private void AddTask()
        {
            NewTaskWindow newTaskWindow = new NewTaskWindow(Tasks);
            newTaskWindow.ShowDialog();
        }

    }
}
