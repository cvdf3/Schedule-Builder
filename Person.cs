using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Builder
{
    public class Person
    {
        //fields need to match the names of the SQL column to query correctly
        public string ID { get; set; }

        public string Name { get; set; }

        public string Admin_ { get; set; }

        public string Shift_ { get; set; }

        public string Position { get; set; }

        public string Kelly_Day { get; set; }

        public string Station { get; set; }

        public string displayInfo
        {
            get
            {
                return $"{ ID }:  { Name }  -  { Position }   K-Day: { Kelly_Day }   St: { Station }  " +
                    $"(Admin: { Admin_ })";
            }
        }

        public string Date_ { get; set; }
    }
}
