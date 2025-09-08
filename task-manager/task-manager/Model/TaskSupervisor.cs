using System.Collections.ObjectModel;
using System.Windows.Navigation;

namespace task_manager.Model
{
    public class TaskSupervisor
    {
        public static ObservableCollection<Task> _TaskDatabase = new ObservableCollection<Task>() { new Task() { Name = "Task 1", DueDate = "10-Sep-25", Description = "This is the first task" }, new Task() { Name = "Task 2", DueDate = "07-Sep-25", Description = "This is the second task" }, new Task() { Name = "Task 3", DueDate = "11-Nov-25", Description = "This is the third task" }, new Task() { Name = "Task 4", DueDate = "06-Sep-25", Description = "This is the fourth task" } };

        public ObservableCollection<Task> GetTasks()
        {
            return _TaskDatabase;
        }

        public void AddTask(Task task)
        {
            _TaskDatabase.Add(task);
        }

    }
}
