using System.Collections.ObjectModel;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using task_manager.Model;
using task_manager.MVVM;
using Task = task_manager.Model.Task;

/***
 * This class is for the window that appears when creating a new task.
 * This holds all the logic for how to handle data inputed to create a new task.
 * 
 * 
 */


namespace task_manager.ViewModel
{
    public class NewTaskWindowViewModel
    {
        // Local Veriables.
        public ICommand SaveNewTaskCommand { get; set; }
        public ObservableCollection<Task> Tasks;
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public DatePicker? TaskDueDate { get; set; }

        /***
         * Constructor
         * 
         * Parameter: tasks (Task) takes a collection of tasks that are already added to a list.
         * 
         */
        public NewTaskWindowViewModel(System.Collections.ObjectModel.ObservableCollection<Task> tasks) {
            SaveNewTaskCommand = new RelayCommand(AddNewTask, CanAddTask);
            Tasks = tasks;
        }

        // Returns true if a task can be added to the list. 
        private bool CanAddTask(object arg)
        {
            return true;
        }

        public void AddNewTaskTest(object arg) { 
            AddNewTask(arg);
        }

        // Addes a new task to the list.
        // Parameter: obj (Object), takes the data entered into the text boxes to create a new task.
        private void AddNewTask(object obj)
        {
            //Check if the new task being added is populated with a Task name and a description.
            if (TaskName != null && TaskDescription != null)
            {   
                //Adding a due date to the task as a string
                string inMyString;
                if (TaskDueDate != null)
                {
                    inMyString = TaskDueDate.SelectedDate.Value.ToShortDateString();
                }
                else
                {   
                    // If a date is not seleted, select a current date.
                    inMyString = DateTime.Today.ToShortDateString();
                }
                // Add the task to the list of Tasks.
                Tasks.Add(new Task { Name = TaskName, Description = TaskDescription, DueDate = inMyString, IsCompleted = false });
            }
        }
    }
}
