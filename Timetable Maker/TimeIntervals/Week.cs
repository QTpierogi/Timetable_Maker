using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Maker
{
    public class Week
    {
        public readonly DateTime StartDate;
        public readonly DateTime EndDate;
        private List<Day> dayList { get; set; }
        private List<ITask> unplacedTasks { get; set; }

        public Week(List<Day> dayList, List<ITask> unplacedTasks, DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
            this.dayList = dayList;
            this.unplacedTasks = unplacedTasks;
        }

        public void AddDay(Day day)
        {
            dayList.Add(day);
        }

        public void RemoveDay(Day day)
        {
            dayList.Remove(day);
        }
    }
}
