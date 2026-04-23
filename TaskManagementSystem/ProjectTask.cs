using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    // Inheritance: ProjectTask inherits everything from AbstractTask
    public class ProjectTask : AbstractTask
    {
        // Additional property unique to ProjectTask 
        public string ProjectName { get; set; }

        // Constructor 
        // Sets all fields including the inherited ones from AbstractTask
        public ProjectTask(int id, string title, int priorityLevel, string projectName)
        {
            Id = id;                        // Inherited from AbstractTask
            Title = title;                  // Inherited from AbstractTask
            PriorityLevel = priorityLevel;  // Inherited — uses validated setter
            ProjectName = projectName;      // Own property
        }

        // Override abstract method from AbstractTask
        // Demonstrates polymorphism: each subclass returns its own category
        public override string GetTaskCategory()
        {
            return $"Project [{ProjectName}]";
        }
    }
}
