using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Schedule_Builder
{
    public partial class EditLeave : Form
    {
        DataAccess db = new DataAccess();
        Param paramEL = new Param();

        public EditLeave(string id, string name, string day, string month, string year)
        {
            InitializeComponent();

            paramEL.ID = id; paramEL.Name = name; paramEL.Year = year; paramEL.Month = month; paramEL.Day = day;

            lblID.Text = $"#{ id }:"; lblName.Text = name; lblDay.Text = day;
            lblMonth.Text = month; lblYear.Text = year;

            fillForm(id, paramEL.Date);
        }

        private void fillForm(string id, string date)
        {
            List<LeaveInfo> view = db.getLeaveInfo(id, date);

            if(view.Count() > 0)
            {
                boxLeave.Text = view[0].Leave; boxTDY.Text = view[0].TDY; boxAppointments.Text = view[0].Appointments;
                boxUnavail.Text = view[0].Unavailable;
            }
        }

        private void btnAddLeave_Click(object sender, EventArgs e)
        {
            try
            {
                db.addLeaveInfo(paramEL.ID, paramEL.Name, paramEL.Date, boxLeave.Text, boxTDY.Text,
                    boxAppointments.Text, boxUnavail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
