using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace task_manager.MVVM
{
    // This class checks to see if a value in the tasks list is selected.
    // If it is, trigger the appropriate call to display information for that task.
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
