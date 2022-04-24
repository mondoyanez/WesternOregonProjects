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
    public partial class AddVehicle : Form
    {
        string username = "name";
        public AddVehicle()
        {
            InitializeComponent();
        }

        public AddVehicle(string name)
        {
            username = name;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var make = txtbxMake.Text;
            var model = txtbxModel.Text;
            var licensePlate = txtbxLP.Text;

            var database = new SqlServerDataRepository();
            database.CreateVehicle(username, make, model, licensePlate);

            this.Hide();
            this.Close();
        }
    }
}
