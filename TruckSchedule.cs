using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Schedule_Builder
{
    public partial class TruckSchedule : Form
    {
        DataAccess db = new DataAccess();
        Param paramTS = new Param();

        public TruckSchedule(string shift, string day, string month, string year)
        {
            InitializeComponent();
            paramTS.Shift = shift; paramTS.Year = year; paramTS.Month = month; paramTS.Day = day;

            dateLabel.Text = $" { day }, { Helper.getMonth(month) } { year }  { shift } Shift";

            scheduleTemplate(shift);

            fillListBoxes(paramTS.Date, shift);
        }

        private void scheduleTemplate(string shift)
        {
            List<DataGridView> stations = new List<DataGridView> { gridSt1, gridSt2, gridSt3 };
            List<Truck> tblTrucks = db.getTrucks();
            DataGridViewComboBoxColumn comboCell = new DataGridViewComboBoxColumn();

            List<Person> peopleOnShift = db.getOnShift(shift, paramTS.Date);
           
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
                    (stations[i].Rows[j].Cells[0] as DataGridViewComboBoxCell).DisplayStyle =
                        DataGridViewComboBoxDisplayStyle.Nothing;

                    for (int n = 0; n < peopleOnShift.Count(); n++)
                    {
                        (stations[i].Rows[j].Cells[0] as DataGridViewComboBoxCell).Items.Add(peopleOnShift[n].Name);
                    }
                }
            }
        }

        private void fillListBoxes(string date, string shift)
        {
            List<LeaveInfo> all = db.getLeaveInfoDate(date);
            List<LeaveInfo> leave = new List<LeaveInfo>();
            List<LeaveInfo> tdy = new List<LeaveInfo>();
            List<LeaveInfo> unavail = new List<LeaveInfo>();

            for (int i = 0; i < all.Count(); i++)
            {
                if (all[i].Leave != "")
                {
                    leave.Add(all[i]);
                }
                if (all[i].TDY != "")
                {
                    tdy.Add(all[i]);
                }
                if (all[i].Unavailable != "")
                {
                    unavail.Add(all[i]);
                }
                if (all[i].Appointments == "")
                {
                    all.Remove(all[i]);
                }
            }

            lbLeave.DataSource = leave;
            lbTDY.DataSource = tdy;
            lbUnavail.DataSource = unavail;
            lbNotes.DataSource = all;

            lbLeave.DisplayMember = "Name";
            lbTDY.DisplayMember = "Name";
            lbUnavail.DisplayMember = "Name";
            lbNotes.DisplayMember = "AppointmentInfo";
        }

        Bitmap bmp;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            e.Graphics.DrawImage(bmp, e.MarginBounds);
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
