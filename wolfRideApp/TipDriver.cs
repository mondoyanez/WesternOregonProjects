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
    public partial class TipDriver : Form
    {
        public string username = "name";
        public TipDriver()
        {
            InitializeComponent();
        }
        public TipDriver(string name)
        {
            username = name;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var amountTipped = numericUpDown1.Value;
            var driverUsername = txtbxUsername.Text;

            var database = new SqlServerDataRepository();
            database.TipDriver(driverUsername, username, amountTipped);

            this.Hide();
            this.Close();
        }
    }
}
