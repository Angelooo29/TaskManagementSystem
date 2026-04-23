using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class PriorityService
    {
        public string SetPriority(int level)
        {
            if (level < 1 || level > 5)
                return "Error: Invalid Priority";

            return "Priority set to " + level;
        }
    }
}
