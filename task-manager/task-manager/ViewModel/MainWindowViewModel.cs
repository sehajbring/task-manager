using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media;
using task_manager.Model;
using task_manager.MVVM;
using task_manager.View;
using Task = task_manager.Model.Task;

namespace TaskManager.ViewModel
{

    /***
     * This class is for the window that appears when starting the program.
     * This holds all the logic for how to handle data on the window as well as how to manage changes made to the 
     * appropriate fields.
     * This class was deigned with the MVVM model where it seperates business logic from UI logic.
     */
    internal class MainWindowViewModel : ViewModelBase
    {
        // Check for if any buttons are clicked on the main window.
        public RelayCommand AddTaskCommand => new RelayCommand(execute => AddTask());
        public RelayCommand SaveNewTaskCommand => new RelayCommand(execute => SaveTask());
        public RelayCommand DeleteTaskCommand => new RelayCommand(execute => DeleteTask());

        private void SaveTask()
        {
        }
        public string SatusColor { get; set; }

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
