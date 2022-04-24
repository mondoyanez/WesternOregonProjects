
namespace wolfRideApp
{
    partial class PassengerHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPickup = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnApplyDrive = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.btnCurrentBalance = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.btnCurrentRides = new System.Windows.Forms.Button();
            this.dataGridViewRides = new System.Windows.Forms.DataGridView();
            this.txtCurrentRides = new System.Windows.Forms.Label();
            this.btnDrive = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTip = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRides)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(499, 374);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPickup
            // 
            this.btnPickup.Location = new System.Drawing.Point(32, 57);
            this.btnPickup.Name = "btnPickup";
            this.btnPickup.Size = new System.Drawing.Size(113, 23);
            this.btnPickup.TabIndex = 1;
            this.btnPickup.Text = "Request Pickup";
            this.btnPickup.UseVisualStyleBackColor = true;
            this.btnPickup.Click += new System.EventHandler(this.btnPickup_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(462, 28);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(112, 23);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.Text = "Add Funds";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnApplyDrive
            // 
            this.btnApplyDrive.Location = new System.Drawing.Point(261, 374);
            this.btnApplyDrive.Name = "btnApplyDrive";
            this.btnApplyDrive.Size = new System.Drawing.Size(113, 23);
            this.btnApplyDrive.TabIndex = 3;
            this.btnApplyDrive.Text = "Apply To Be Driver";
            this.btnApplyDrive.UseVisualStyleBackColor = true;
            this.btnApplyDrive.Click += new System.EventHandler(this.btnApplyDrive_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(143, 374);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(112, 23);
            this.btnContact.TabIndex = 4;
            this.btnContact.Text = "Contact Admin";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWelcome.Location = new System.Drawing.Point(238, 9);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(141, 31);
            this.txtWelcome.TabIndex = 5;
            this.txtWelcome.Text = "Welcome";
            // 
            // btnCurrentBalance
            // 
            this.btnCurrentBalance.Location = new System.Drawing.Point(462, 57);
            this.btnCurrentBalance.Name = "btnCurrentBalance";
            this.btnCurrentBalance.Size = new System.Drawing.Size(112, 23);
            this.btnCurrentBalance.TabIndex = 6;
            this.btnCurrentBalance.Text = "Current Balance";
            this.btnCurrentBalance.UseVisualStyleBackColor = true;
            this.btnCurrentBalance.Click += new System.EventHandler(this.btnCurrentBalance_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(201, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(95, 31);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "Name";
            // 
            // btnCurrentRides
            // 
            this.btnCurrentRides.Location = new System.Drawing.Point(33, 87);
            this.btnCurrentRides.Name = "btnCurrentRides";
            this.btnCurrentRides.Size = new System.Drawing.Size(112, 23);
            this.btnCurrentRides.TabIndex = 8;
            this.btnCurrentRides.Text = "Current Rides";
            this.btnCurrentRides.UseVisualStyleBackColor = true;
            this.btnCurrentRides.Click += new System.EventHandler(this.btnCurrentRides_Click);
            // 
            // dataGridViewRides
            // 
            this.dataGridViewRides.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewRides.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRides.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRides.Location = new System.Drawing.Point(33, 149);
            this.dataGridViewRides.Name = "dataGridViewRides";
            this.dataGridViewRides.RowTemplate.Height = 25;
            this.dataGridViewRides.Size = new System.Drawing.Size(541, 192);
            this.dataGridViewRides.TabIndex = 9;
            this.dataGridViewRides.Visible = false;
            // 
            // txtCurrentRides
            // 
            this.txtCurrentRides.AutoSize = true;
            this.txtCurrentRides.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCurrentRides.Location = new System.Drawing.Point(239, 128);
            this.txtCurrentRides.Name = "txtCurrentRides";
            this.txtCurrentRides.Size = new System.Drawing.Size(123, 18);
            this.txtCurrentRides.TabIndex = 10;
            this.txtCurrentRides.Text = "Current Rides";
            this.txtCurrentRides.Visible = false;
            // 
            // btnDrive
            // 
            this.btnDrive.Location = new System.Drawing.Point(380, 374);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Size = new System.Drawing.Size(113, 23);
            this.btnDrive.TabIndex = 11;
            this.btnDrive.Text = "Sign In As Driver";
            this.btnDrive.UseVisualStyleBackColor = true;
            this.btnDrive.Click += new System.EventHandler(this.btnDrive_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(25, 374);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(112, 23);
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.Text = "Admin Mode";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTip
            // 
            this.btnTip.Location = new System.Drawing.Point(462, 86);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(112, 23);
            this.btnTip.TabIndex = 13;
            this.btnTip.Text = "Tip Driver";
            this.btnTip.UseVisualStyleBackColor = true;
            this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Past Rides";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassengerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTip);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnDrive);
            this.Controls.Add(this.txtCurrentRides);
            this.Controls.Add(this.dataGridViewRides);
            this.Controls.Add(this.btnCurrentRides);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCurrentBalance);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnApplyDrive);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnPickup);
            this.Controls.Add(this.btnLogout);
            this.Name = "PassengerHome";
            this.Text = "Passenger Home Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRides)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPickup;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnApplyDrive;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Label l;
        public System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Button btnCurrentBalance;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button btnCurrentRides;
        private System.Windows.Forms.DataGridView dataGridViewRides;
        private System.Windows.Forms.Label txtCurrentRides;
        private System.Windows.Forms.Button btnDrive;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnTip;
        private System.Windows.Forms.Button button1;
    }
}