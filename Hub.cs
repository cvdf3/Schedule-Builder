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
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void btnEditPersonnel_Click(object sender, EventArgs e)
        {
            PersonnelList l = new PersonnelList();
            l.Show();
        }

        private void btnEditTrucks_Click(object sender, EventArgs e)
        {
            EditTrucks t = new EditTrucks();
            t.Show();
        }

        private void btnLeaveCalendar_Click(object sender, EventArgs e)
        {
            LeaveCalendar c = new LeaveCalendar();
            c.Show();
        }
    }
}
