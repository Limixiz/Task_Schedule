using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Schedule.Models
{
    public class TaskModel
    {
        public string TaskName { get; set; }
        public DateTime TaskStart { get; set; }
        public bool TaskAllDay { get; set; }
        public DateTime TaskEnd { get; set; }
        public string TaskDescription { get; set; }
    }
}
