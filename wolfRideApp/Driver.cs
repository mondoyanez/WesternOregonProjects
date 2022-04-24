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
    public partial class Driver : Form
    {
        public string username = "name";
        public Driver()
        {
            InitializeComponent();
        }

        public Driver(string newName)
        {
            username = newName;
            InitializeComponent();
        }

        private void btnWaiting_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.RiderWaiting(dataGridView1);
            dataGridView1.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btnMyRiders_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.MyRiders(username, dataGridView1);
            dataGridView1.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            if (database.isAdmin(username))
            {
                this.Hide();
                Admin a = new Admin(username);
                a.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Access Denied, you are not an Admin!");
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle av = new AddVehicle(username);
            av.ShowDialog();
        }

        private void btnRemoveVehicle_Click(object sender, EventArgs e)
        {
            RemoveVehicle rv = new RemoveVehicle();
            rv.ShowDialog();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.MyVehicles(username, dataGridView1);
            dataGridView1.Show();
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            PickUpPassenger p = new PickUpPassenger(username);
            p.ShowDialog();
        }

        private void btnRideCompleted_Click(object sender, EventArgs e)
        {
            RideCompleted c = new RideCompleted(username);
            c.ShowDialog();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            var balance = database.GetBalance(username);
            MessageBox.Show("Current balance: $" + balance);
        }

        private void btnPassengerHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengerHome p = new PassengerHome(username);
            p.ShowDialog();
            this.Close();
        }
    }
}
