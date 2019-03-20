using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Builder
{
    public class LeaveInfo
    {
        public string Name { get; set; }

        public string Date { get; set; }

        public string Leave { get; set; }
        
        public string TDY { get; set; }

        public string Appointments { get; set; }

        public string Unavailable { get; set; }

        public string getLeaveInfo
        {
            get
            {
                return $"{ Name } { Date } { Leave } { TDY } { Appointments }";
            }
        }

    }
}
