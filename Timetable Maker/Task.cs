using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Maker
{
    //Элемент рассписания, может быть как закрепленным (если указать время начала, продолжительность и дедлайн),
    //так и свободным если указать только продолжительность
    public class Task 
    {
        public TimeSpan RequiredTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime DeadLine { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Task(string name, string description, TimeSpan requiredTime,
            DateTime startTime = default(DateTime), DateTime deadLine = default(DateTime))
        {
            Name = name;
            Description = description;
            RequiredTime = requiredTime;
            StartTime = startTime;
            DeadLine = deadLine;
        }
    }
}
