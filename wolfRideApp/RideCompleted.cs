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
    public partial class RideCompleted : Form
    {
        public string username = "name";
        public RideCompleted()
        {
            InitializeComponent();
        }
        public RideCompleted(string name)
        {
            username = name;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int rideID = Convert.ToInt32(numericUpDown.Value);

            var database = new SqlServerDataRepository();
            database.RideCompleted(username, rideID);

            this.Hide();
            this.Close();
        }
    }
}
