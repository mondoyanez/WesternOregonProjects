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
    public partial class pickUp : Form
    {
        public string username = "user";
        public pickUp()
        {
            InitializeComponent();
        }

        public pickUp(string newUser)
        {
            username = newUser;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string destination = txtbxDestination.Text;
            int passengers = Convert.ToInt32(numericUpDownPassenger.Value);

            var database = new SqlServerDataRepository();
            database.RequestRide(username, destination, passengers);
            this.Hide();
            this.Close();
        }
    }
}
