using System;
using System.Collections.Generic;
using System.Text;

namespace Assessed_Exercise_task_A
{
    class Task : IComparable
    {
        private string description;

        public Task(string description) // constructor for a task
        {
            this.description = description;
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int CompareTo(Object obj)  // allows tasks to be ordered
        {					

            Task other = (Task)obj;
            return Description.CompareTo(other.Description);
        }
        public string ToString()
        {
            return description;
        }
    }
}
