using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Builder
{
    public partial class TruckSchedule : Form
    {
        DataAccess db = new DataAccess();

        public TruckSchedule(string shift, string day, string month, string year)
        {
            InitializeComponent();

            dateLabel.Text = $" { day }, { getMonth(month) } { year }  { shift } Shift";

            scheduleTemplate(shift);
        }

        public void scheduleTemplate(string shift)
        {
            List<DataGridView> stations = new List<DataGridView> { gridSt1, gridSt2, gridSt3 };
            List<Truck> tblTrucks = db.getTrucks();
            DataGridViewComboBoxColumn comboCell = new DataGridViewComboBoxColumn();

            List<Person> peopleOnShift = db.getShift(shift);
           
            for (int i = 0; i < stations.Count(); i++)
            {
                int x = 0;

                List<Truck> selectedTrucks = tblTrucks.FindAll(Truck => Truck.StationNumber == (i + 1).ToString());
            
                for (int j = 0; j < selectedTrucks.Count(); j++)
                {
                    stations[i].RowCount += selectedTrucks[j].numPositions;
            
                    stations[i].Rows[x].HeaderCell.Value = selectedTrucks[j].Number;
                    x += selectedTrucks[j].numPositions;

                    stations[i].RowHeadersWidth = 65;
                    stations[i].Columns[0].Width = gridSt1.Width - 67;
                }
            }

            for (int i = 0; i < stations.Count(); i++)
            {
                for (int j = 0; j < stations[i].RowCount; j++)
                {
                    stations[i].Rows[j].Cells[0] = new DataGridViewComboBoxCell();
                    ;
                    (stations[i].Rows[j].Cells[0] as DataGridViewComboBoxCell).DisplayStyle =
                        DataGridViewComboBoxDisplayStyle.Nothing;

                    for (int n = 0; n < peopleOnShift.Count(); n++)
                    {
                        (stations[i].Rows[j].Cells[0] as DataGridViewComboBoxCell).Items.Add(peopleOnShift[n].Name);
                    }
                }
            }
        }

        private string getMonth(string num)
        {
            switch (num)
            {
                case "1":
                    return "January";
                case "2":
                    return "February";
                case "3":
                    return "March";
                case "4":
                    return "April";
                case "5":
                    return "May";
                case "6":
                    return "June";
                case "7":
                    return "July";
                case "8":
                    return "August";
                case "9":
                    return "September";
                case "10":
                    return "October";
                case "11":
                    return "November";
                case "12":
                    return "December";
            }
            return null;
        }
    }
}
