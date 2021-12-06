using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Maker
{
    public static class Generator
    {
        // Принимает список всех задач и возвращает список дней с отсортированными задачами
        // Думаю он должен возвращать 8 дней чтобы в 8 день помещал все задачи которые ему не удалось распределить
        public static List<Day> GenerateWeek(List<Task> taskList)
        {
            throw new NotImplementedException();
        }


        // Должен принять список всех задач отобрать только те которые должны быть в этом дне и
        // еще могут вместиться в этот день, вернуть Day и к примеру удалить из taskList дела которые он использовал.
        public static Day GenerateDay(List<Task> taskList)
        {
            throw new NotImplementedException();
        }
    }
}
