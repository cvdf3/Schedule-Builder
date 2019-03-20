using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Builder
{
    public class Truck
    {
        public string Number { get; set; }

        public string StationNumber { get; set; }

        public string Positions { get; set; }

        public string displayTruckInfo
        {
            get
            {
                return $" { Number }:   Station { StationNumber } ";
            }
        }

        public int numPositions
        {
            get
            {
                return Convert.ToInt32(Positions);
            }
        }
    }
}
