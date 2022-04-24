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
    public partial class addFunds : Form
    {
        public string user = "user";
        public addFunds()
        {
            InitializeComponent();
        }

        public addFunds(string currentUser)
        {
            user = currentUser;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var database = new SqlServerDataRepository();
            var newAmount = numericUpDownAmount.Value;
            database.AddFunds(user, newAmount);

            this.Hide();
            this.Close();
        }
    }
}
