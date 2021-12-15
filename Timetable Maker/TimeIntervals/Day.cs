using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Maker
{
    public class Day
    {
        public readonly DateTime Date;
        private List<ITask> taskList { get; set; }
        public List<ITask> unplacedTasks { get; set; }

        public Day(List<ITask> taskList, List<ITask> unplacedTasks, DateTime date)
        {
            Date = date;
            this.taskList = taskList;
            this.unplacedTasks = unplacedTasks;
        }

        public void AddTask(ITask task)
        {
            taskList.Add(task);
        }

        public void RemoveTask(ITask task)
        {
            taskList.Remove(task);
        }
    }
}
