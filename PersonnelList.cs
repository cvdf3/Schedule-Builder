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
    public partial class PersonnelList : Form
    {
        DataAccess db = new DataAccess();

        List<Person> aShift = new List<Person>();
        List<Person> bShift = new List<Person>();

        public PersonnelList()
        {
            InitializeComponent();
            
            aShift = db.getShift("A");
            bShift = db.getShift("B");

            updateBinding();
        }

        private void updateBinding()
        {
            lbAshift.DataSource = aShift;
            lbAshift.DisplayMember = "displayInfo";

            lbBshift.DataSource = bShift;
            lbBshift.DisplayMember = "displayInfo";
            //this.Refresh();
        }
        
        //clears the field boxes
        private void clearBoxes()
        {
            boxID.Clear(); boxName.Clear();

            boxAdmin.Items.Clear(); boxShift.Items.Clear(); boxPosition.Items.Clear(); boxKellyDay.Items.Clear();
            boxStation.Items.Clear();
        }

        //adds the information in the fields to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool boxesFilled = !string.IsNullOrWhiteSpace(boxID.Text) && !string.IsNullOrWhiteSpace(boxName.Text) &&
                !string.IsNullOrWhiteSpace(boxAdmin.Text) && !string.IsNullOrWhiteSpace(boxShift.Text) &&
                !string.IsNullOrWhiteSpace(boxPosition.Text) && !string.IsNullOrWhiteSpace(boxKellyDay.Text);

            if (boxesFilled)
            {
                db.addUpdate(boxID.Text, boxName.Text, boxAdmin.Text, boxShift.Text, boxPosition.Text,
                    boxKellyDay.Text, boxStation.Text);

                clearBoxes();
                updateBinding();
            }
            else
            {
                MessageBox.Show("Error: Please fill in all of the fields (Station is optional).");
            }
        }

        //delete the selected personnel from the database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //add an 'Are you sure' form
            if (!string.IsNullOrWhiteSpace(boxID.Text) && !string.IsNullOrWhiteSpace(boxName.Text))
            {
                db.deletePerson(boxID.Text, boxName.Text);

                clearBoxes();
                updateBinding();
            }
            else
            {
                MessageBox.Show("Error: Please enter the ID number or Name of the person you want to remove.");
            }
        }

        //fills the boxes with the clicked person's information
        private void lbAshift_MouseClick(object sender, MouseEventArgs e)
        {
            Person selected = (Person)lbAshift.SelectedItem;

            boxID.Text = selected.ID; boxName.Text = selected.Name; boxAdmin.Text = selected.Admin_;
            boxShift.Text = selected.Shift_; boxPosition.Text = selected.Position;
            boxKellyDay.Text = selected.Kelly_Day; boxStation.Text = selected.Station;
        }

        private void lbBshift_MouseClick(object sender, MouseEventArgs e)
        {
            Person selected = (Person)lbBshift.SelectedItem;

            boxID.Text = selected.ID; boxName.Text = selected.Name; boxAdmin.Text = selected.Admin_;
            boxShift.Text = selected.Shift_; boxPosition.Text = selected.Position;
            boxKellyDay.Text = selected.Kelly_Day; boxStation.Text = selected.Station;
        }
    }
}
