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
    public partial class PassengerHome : Form
    {
        public PassengerHome()
        {
            InitializeComponent();
        }

        public PassengerHome(string name)
        {
            InitializeComponent();
            txtName.Text = name;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            addFunds af = new addFunds(txtName.Text);
            af.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btnCurrentBalance_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();

            var currentBalance = database.GetBalance(txtName.Text);
            MessageBox.Show("Current Balance: $" + currentBalance);
        }

        private void btnPickup_Click(object sender, EventArgs e)
        {
            pickUp pu = new pickUp(txtName.Text);
            pu.ShowDialog();
        }

        private void btnCurrentRides_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.getCurrentRide(txtName.Text, dataGridViewRides);

            txtCurrentRides.Show();
            dataGridViewRides.Show();
        }

        private void btnDrive_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            var credential = database.GetCredential(txtName.Text);

            if (database.isDriver(txtName.Text))
            {
                this.Hide();
                Driver d = new Driver(txtName.Text);
                d.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("SORRY YOU ARE NOT REGISTERED AS A DRIVER PLEASE APPLY TO BE ONE IF YOU ARE INTERESTED.");
            }
        }

        private void btnApplyDrive_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.DriverApply(txtName.Text);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            AdminSupport a = new AdminSupport(txtName.Text);
            a.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            if (database.isAdmin(txtName.Text))
            {
                this.Hide();
                Admin a = new Admin(txtName.Text);
                a.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Access Denied, you are not an Admin!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            database.PastRides(txtName.Text, dataGridViewRides);

            txtCurrentRides.Show();
            dataGridViewRides.Show();
        }

        private void btnTip_Click(object sender, EventArgs e)
        {
            TipDriver t = new TipDriver(txtName.Text);
            t.ShowDialog();
        }
    }
}
