using Microsoft.VisualBasic;

/***
 *  Struct for a task
 * 
 */

namespace task_manager.Model
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }

        public bool IsCompleted = false;
    }
}
