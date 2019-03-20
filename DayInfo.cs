using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Builder
{
    public class DayInfo
    {
        public string Date { get; set; }

        public string Day { get; set; }

        public string WorkingShift { get; set; }

        public string displayDayInfo
        {
            get
            {
                return $" { Date } { Day } { WorkingShift } ";
            }
        }
    }
}
