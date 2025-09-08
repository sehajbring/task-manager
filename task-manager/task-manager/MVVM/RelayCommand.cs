using System.Windows.Input;

/***
 * Commands to be used to seperate the semantics and the object that invokes a command from the logic that executes the command.
 * Seperates the UI from the logic that needs to be executed on command invocation.
 * 
 */
namespace task_manager.MVVM
{

    internal class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        // Initializes a new instance of "DelegateCommand{T}
        // name="execute" Delegate to execute when Execute is called on the command.  This can be null to just hook up a CanExecute delegate.
        // CanExecute will always return true.
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) 
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        // Defines the method that determines whether the command can execute in its current state.
        // parameter: Data used by the command.  If the command does not require data to be passed, this object can be set to null.
        //true if this command can be executed; otherwise, false.
        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        //Defines the method to be called when the command is invoked.
        //name="parameter" Data used by the command. If the command does not require data to be passed, this object can be set to null
        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
