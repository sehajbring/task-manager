# Task Manager

A simple WPF application for managing tasks. This project allows users to view, add, and delete tasks in a user-friendly interface.

## Features

- **View Tasks:** Displays a list of tasks with their name, description, due date, and completion status.
- **Add Task:** Opens a window to create a new task and add it to the list.
- **Delete Task:** Removes the selected task from the list.
- **Current Date Display:** Shows the current date in the main window.

## Technologies Used

- .NET 8.0 (Windows)
- C# 12
- WPF (Windows Presentation Foundation)
- MVVM Pattern

## Getting Started

1. **Clone the repository:**

   git clone https://github.com/sehajbring/task-manager.git

3. **Open the solution in Visual Studio 2022.**
4. **Build and run the project.**

## Usage

- **Add Task:** Click the "Add Task" button to open the new task window. Fill in the details and save.
- **Delete Task:** Select a task from the list and click "Delete Task" to remove it.
- **View Tasks:** All tasks are displayed in the main window.
- **Add Due Date:** Add or modify a due date for a given task.

## Project Structure

- `Model/Task.cs` - Task data model.
- `View/MainWindow.xaml` - Main application window.
- `View/NewTaskWindow.xaml` - Window for adding new tasks.
- `ViewModel/MainWindowViewModel.cs` - Main window logic and commands.
- `MVVM/RelayCommand.cs` - Command implementation for MVVM.

## License

This project is licensed under the MIT License.

---

_This README was generated based on the current functionality of the program._
