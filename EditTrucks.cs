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
    public partial class EditTrucks : Form
    {
        DataAccess db = new DataAccess();

        List<Truck> trucks = new List<Truck>();

        public EditTrucks()
        {
            InitializeComponent();

            trucks = db.getTrucks();

            updateBinding();
        }

        private void updateBinding()
        {
            lbTrucks.DataSource = trucks;
            lbTrucks.DisplayMember = "displayTruckInfo";
            //this.Refresh();
        }

        private void clearBoxes()
        {
            boxNum.Clear(); boxStation.Clear(); boxPositions.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool boxesFilled = !string.IsNullOrWhiteSpace(boxNum.Text) && !string.IsNullOrWhiteSpace(boxStation.Text) &&
                !string.IsNullOrWhiteSpace(boxPositions.Text);

            if (boxesFilled)
            {
                db.addUpdateTruck(boxNum.Text, boxStation.Text, boxPositions.Text);

                clearBoxes();
                updateBinding();
            }
            else
            {
                MessageBox.Show("Error: Please fill in all of the fields.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(boxNum.Text))
            {
                db.deleteTruck(boxNum.Text);

                clearBoxes();
                updateBinding();
            }
            else
            {
                MessageBox.Show("Error: Please enter the number of the truck you want to remove.");
            }
        }

        private void lbTrucks_MouseClick(object sender, MouseEventArgs e)
        {
            Truck selected = (Truck)lbTrucks.SelectedItem;

            boxNum.Text = selected.Number; boxStation.Text = selected.StationNumber;
            boxPositions.Text = selected.Positions;
        }
    }
}
