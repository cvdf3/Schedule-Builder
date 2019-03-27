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

        //fill the calendar----------------------------------------------------------------------------------------
        private void fillCalendar(string month, string year, string shift = "A")
        {
            lblMonth.Text = Helper.getMonth(month);
            lblYear.Text = year;
            lblShift.Text = shift;

            List<DayInfo> tblMonth = db.getDays(month, year);
            List<Person> tblPersonnel = db.getShift(shift);

            var columnNum = tblMonth.Count();
            var rowNum = tblPersonnel.Count();

            gridCalendar.ColumnCount = columnNum;
            gridCalendar.RowCount = rowNum + 1;
            gridCalendar.RowHeadersWidth = 125;

            //label the days
            for (int i = 0; i < tblMonth.Count(); i++)
            {
                gridCalendar.Columns[i].HeaderText = $"{ tblMonth[i].Day }";
            }

            //lable the rows with the names of the people of the shift
            for (int i = 0; i < rowNum; i++)
            {
                gridCalendar.Rows[i].HeaderCell.Value = $"{ tblPersonnel[i].ID }: { tblPersonnel[i].Name }";
            }
            gridCalendar.Rows[rowNum].HeaderCell.Value = "On Shift";

            //fill the cells with the information of the people of each day
            //columns
            for (int i = 0; i < columnNum; i++)
            {
                List<LeaveInfo> peopleOnLeave = db.getLeaveInfoDate(($"{ year }{ month.PadLeft(2, '0') }" +
                    $"{ (i + 1).ToString().PadLeft(2, '0') }"));

                int count = 0;

                //rows
                for (int j = 0; j < rowNum; j++)
                { 
                    //iterate through the people on leave, etc for each cell
                    string[] idAndName = gridCalendar.Rows[j].HeaderCell.Value.ToString().
                        Split(new[] { ": " }, StringSplitOptions.None);

                    for (int n = 0; n < peopleOnLeave.Count(); n++)
                    {
                        if (peopleOnLeave[n].Name != idAndName[1])
                        {
                            gridCalendar.Rows[j].Cells[i].Value = null;
                        }
                        else
                        {
                            gridCalendar.Rows[j].Cells[i].Value = peopleOnLeave[n].CalendarInfo;
                        }
                    }

                    //determine whether it is a working day for that person
                    if (tblMonth[i].WorkingShift != tblPersonnel[j].Shift_)
                    {
                        gridCalendar.Rows[j].Cells[i].Style.BackColor = Color.Red;
                        gridCalendar.Rows[j].Cells[i].Style.ForeColor = Color.White;
                    }
                    if (gridCalendar.Rows[j].Cells[i].Value != null)
                    {
                        count += 1;
                    }

                    gridCalendar.Rows[rowNum].Cells[i].Value = $"{ rowNum - count }";
                }
            }
        }

        //refills the calendar with the specified information---------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridCalendar.Rows.Clear();
            fillCalendar(boxMonth.Text, boxYear.Text, boxShift.Text);
        }

        //opens the daily schedule for the specified day
        private void gridCalendar_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            string day = gridCalendar.Columns[e.ColumnIndex].HeaderText;

            TruckSchedule t = new TruckSchedule(lblShift.Text, day, lblMonth.Text, lblYear.Text);
            t.Show();
        }

        //opens the form to edit leave and appointments for the specified person on the specified day
        private void gridCalendar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] idAndName = gridCalendar.Rows[e.RowIndex].HeaderCell.Value.ToString().
                    Split(new[] { ": " }, StringSplitOptions.None);

                string day = gridCalendar.Columns[e.ColumnIndex].HeaderText;
                
                EditLeave l = new EditLeave(idAndName[0], idAndName[1], day, lblMonth.Text, lblYear.Text);
                l.Show();
            }
            catch
            {
                MessageBox.Show("Please select a valid cell.");
            }
        }
    }
}
