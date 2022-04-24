using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wolfRideApp
{
    public partial class PickUpPassenger : Form
    {
        public string username = "name";
        public PickUpPassenger()
        {
            InitializeComponent();
        }
        public PickUpPassenger(string name)
        {
            username = name;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int rideID = Convert.ToInt32(numericUpDown.Value);
            string licensePlate = txtbxLP.Text;
            
            var database = new SqlServerDataRepository();
            database.PickUp(username, rideID, licensePlate);

            this.Hide();
            this.Close();
        }
    }
}
