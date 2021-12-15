using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Maker
{
    public interface IDrawer //Лучше разные отрезки времени (день неделя и тд) разделить на разные рисовальщики
    {
        public void Draw();
    }
}
