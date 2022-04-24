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
    public partial class TerminateUser : Form
    {
        public TerminateUser()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = txtbxUsername.Text;
            var database = new SqlServerDataRepository();

            database.TerminateUser(username);

            this.Hide();
            this.Close();
        }
    }
}
