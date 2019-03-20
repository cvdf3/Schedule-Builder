using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Builder
{
    public partial class LeaveCalendar : Form
    {
        DataAccess db = new DataAccess();

        string currentMonth = DateTime.Now.Month.ToString();
        string currentYear = DateTime.Now.Year.ToString();

        public LeaveCalendar()
        {
            InitializeComponent();

            fillCalendar(currentMonth, currentYear);

            boxMonth.Text = currentMonth; boxYear.Text = currentYear; boxShift.Text = "A";
        }

        //fill the calendar
        private void fillCalendar(string month, string year, string shift = "A")
        {
            List<DayInfo> tblMonth = db.getDays(month, year);
            List<Person> tblPersonnel = db.getShift(shift);

            var columnNum = tblMonth.Count();
            var rowNum = tblPersonnel.Count();

            gridCalendar.ColumnCount = columnNum;
            gridCalendar.RowCount = rowNum + 3;
            gridCalendar.RowHeadersWidth = 125;

            for (int i = 1; i <= columnNum; i++)
            {
                gridCalendar.Columns[i - 1].HeaderText = $" { i } ";
            }

            for (int i = 0; i < rowNum; i++)
            {
                gridCalendar.Rows[i].HeaderCell.Value = $" { tblPersonnel[i].Name } ";
            }

            for (int i = 0; i < columnNum; i++)
            {
                for (int j = 0; j < rowNum; j++)
                {
                    if (tblMonth[i].WorkingShift != tblPersonnel[j].Shift_)
                    {
                        gridCalendar.Rows[j].Cells[i].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        gridCalendar.Rows[j].Cells[i].Style.BackColor = Color.White;
                    }
                }
            }
        }

        //refills the calendar with the specified information
        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillCalendar(boxMonth.Text, boxYear.Text, boxShift.Text);
        }

        private void gridCalendar_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            string day = gridCalendar.Columns[e.ColumnIndex].HeaderText;

            TruckSchedule t = new TruckSchedule(boxShift.Text, day, boxMonth.Text, boxYear.Text);
            t.Show();
        }
    }
}
