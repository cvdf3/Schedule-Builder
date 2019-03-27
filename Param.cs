using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Builder
{
    class Param
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Shift { get; set; }

        public string Year { get; set; }

        public string Month { get; set; }

        public string Day { get; set; }

        public string Date
        {
            get
            {
                return $"{ Year }{ Month.PadLeft(2, '0')}{ Day.PadLeft(2, '0')}";
            }
        }
    }
}
