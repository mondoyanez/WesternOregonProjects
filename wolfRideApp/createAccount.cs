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
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }

        private void btnCA_Submit_Click(object sender, EventArgs e)
        {
            var name = txtbx_Name.Text;
            var email = txtbx_Email.Text;
            var phone = txtbx_Phone.Text;
            var line1 = txtbx_Line1.Text;
            var line2 = txtbx_line2.Text;
            var state = (txtbx_State.Text).ToUpper();
            var city = txtbx_City.Text;
            var zip = txtbx_Zip.Text;
            var username = txtbx_Username.Text;
            var password = txtbx_Password.Text;

            if (name.Equals(string.Empty) || email.Equals(string.Empty) || phone.Equals(string.Empty) || line1.Equals(string.Empty) || city.Equals(string.Empty)
                || state.Equals(string.Empty) || zip.Equals(string.Empty) || username.Equals(string.Empty) || password.Equals(string.Empty))
            {
                MessageBox.Show("Please complete all required fields.");
            }
            else
            {
                var credential = new Credential();
                var database = new SqlServerDataRepository();

                credential.FullName = name;
                credential.Email = email;
                credential.Phone = phone;
                credential.Line1 = line1;
                credential.Line2 = line2;
                credential.City = city;
                credential.State = state;
                credential.Zip = zip;
                credential.UserName = username;
                credential.Password = password;

                database.AddCredential(credential);

                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        }
    }
}
