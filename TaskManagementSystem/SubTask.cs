using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class SubTask
    {
        // Encapsulation: private fields with public properties 
        private string _title;
        private bool _isCompleted;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { _isCompleted = value; }
        }

        // Constructor 
        public SubTask(string title)
        {
            _title = title;
            _isCompleted = false;
        }

        // ToString: used when displaying in ListBox
        public override string ToString()
        {
            return $" [{(IsCompleted ? "check" : " ")}] {Title}";
        }
    }
}
