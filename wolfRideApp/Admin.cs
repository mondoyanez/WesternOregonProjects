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
    public partial class Admin : Form
    {
        string username = "name";
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string newName)
        {
            username = newName;
            InitializeComponent();
        }

        private void btnDriverRequest_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.ViewDriverRequests(dataGridView);
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.ViewDrivers(dataGridView);
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.ViewPassengers(dataGridView);
        }

        private void btnViewVehicles_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.ViewVehicles(dataGridView);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.ViewAllUsers(dataGridView);
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.ViewAdmins(dataGridView);
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.ViewMessages(dataGridView);
        }

        private void btnTerminationRequests_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.ViewTerminationRequests(dataGridView);
        }

        private void btnMakeDriver_Click(object sender, EventArgs e)
        {
            AddDriver d = new AddDriver();
            d.ShowDialog();
        }

        private void btnMakeAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin a = new AddAdmin();
            a.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            TerminateUser t = new TerminateUser();
            t.ShowDialog();
        }
    }
}
