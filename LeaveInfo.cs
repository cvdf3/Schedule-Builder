using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Builder
{
    public class LeaveInfo
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Date_ { get; set; }

        public string Leave { get; set; }
        
        public string TDY { get; set; }

        public string Appointments { get; set; }

        public string Unavailable { get; set; }

        public string AppointmentInfo
        {
            get
            {
                return $"{ Name }: { Appointments }";
            }
        }

        public string getLeaveInfo
        {
            get
            {
                return $"{ ID } { Name } { Date_ } { Leave } { TDY } { Appointments }";
            }
        }

        public string CalendarInfo
        {
            get
            {
                string status = "";
                if (Leave != "")
                {
                    status += "Leave ";
                }
                if (TDY != "")
                {
                    status += "TDY ";
                }
                if (Unavailable != "")
                {
                    status += "Unavailable ";
                }
                return status;
            }
        }
    }
}
