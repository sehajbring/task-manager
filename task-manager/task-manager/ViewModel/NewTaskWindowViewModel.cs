using System.Collections.ObjectModel;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Input;
using task_manager.Model;
using task_manager.MVVM;
using Task = task_manager.Model.Task;

namespace task_manager.ViewModel
{
    public class NewTaskWindowViewModel
    {
        public ICommand SaveNewTaskCommand { get; set; }
        public ObservableCollection<Task> Tasks;

        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public string? TaskDueDate { get; set; }

        public NewTaskWindowViewModel(System.Collections.ObjectModel.ObservableCollection<Task> tasks) {
            SaveNewTaskCommand = new RelayCommand(AddNewTask, CanAddTask);
            Tasks = tasks;
        }

        private bool CanAddTask(object arg)
        {
            return true;
        }

        private void AddNewTask(object obj)
        {
            Tasks.Add(new Task { Name = TaskName, Description = TaskDescription, DueDate = TaskDueDate, IsCompleted = false });
        }
    }
}
