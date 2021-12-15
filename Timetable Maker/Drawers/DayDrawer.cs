using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Maker.Drawers
{
    public class DayDrawer : IDrawer
    {
        public Day Day { get; set; }

        public DayDrawer(Day day)
        {
            Day = day;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
