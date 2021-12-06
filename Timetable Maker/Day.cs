using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Maker
{
    //Служит элементом недели и хранит в taskList список задач в правильном (сгенерированном порядке)
    public class Day
    {
        private List<Task> taskList { get; set; }

        public Day(List<Task> taskList)
        {
            this.taskList = taskList;
        }

        public void AddTask(Task task)
        {
            taskList.Add(task);
        }

        public void RemoveTask(Task task)
        {
            taskList.Remove(task);
        }
    }
}
