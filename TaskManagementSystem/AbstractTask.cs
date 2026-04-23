using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{

    public abstract class AbstractTask
    {
        // Encapsulation: private backing fields
        private int _id;
        private string _title;
        private int _priorityLevel;

        // Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        // SECTION 3: Validation lives here — setPriority(int level) logic
        // Valid range is 1 to 5 as per the activity scenario
        public int PriorityLevel
        {
            get { return _priorityLevel; }
            set
            {
                if (value >= 1 && value <= 5)
                    _priorityLevel = value;
                else
                    throw new ArgumentException("Error: Invalid Priority");
            }
        }

        // Each task stores a list of SubTask objects (Section 1 requirement)
        public List<SubTask> SubTasks { get; set; } = new List<SubTask>();

        // Abstract method: must be overridden by all subclasses
        // This demonstrates Inheritance — ProjectTask must implement this
        public abstract string GetTaskCategory();

        // ToString: used when displaying in lstTasks ListBox 
        public override string ToString()
        {
            return $"[ID:{Id}] {Title} | Priority: {PriorityLevel} | {GetTaskCategory()} | SubTasks: {SubTasks.Count}";
        }
    }
}
