using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Maker
{
    public class WeekDrawer : IDrawer
    {
        public Week Week { get; set; }

        public WeekDrawer(Week week)
        {
            Week = week;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
