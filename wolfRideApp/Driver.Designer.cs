
namespace wolfRideApp
{
    partial class Driver
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
            this.txtHome = new System.Windows.Forms.Label();
            this.btnWaiting = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnRemoveVehicle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.btnMyPassengers = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRidesCompleted = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnPassengerHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHome
            // 
            this.txtHome.AutoSize = true;
            this.txtHome.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHome.Location = new System.Drawing.Point(21, 9);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(105, 31);
            this.txtHome.TabIndex = 0;
            this.txtHome.Text = "Driver";
            // 
            // btnWaiting
            // 
            this.btnWaiting.Location = new System.Drawing.Point(28, 64);
            this.btnWaiting.Name = "btnWaiting";
            this.btnWaiting.Size = new System.Drawing.Size(106, 23);
            this.btnWaiting.TabIndex = 1;
            this.btnWaiting.Text = "Riders Waiting";
            this.btnWaiting.UseVisualStyleBackColor = true;
            this.btnWaiting.Click += new System.EventHandler(this.btnWaiting_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(28, 93);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(106, 23);
            this.btnAddVehicle.TabIndex = 2;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnRemoveVehicle
            // 
            this.btnRemoveVehicle.Location = new System.Drawing.Point(28, 122);
            this.btnRemoveVehicle.Name = "btnRemoveVehicle";
            this.btnRemoveVehicle.Size = new System.Drawing.Size(106, 23);
            this.btnRemoveVehicle.TabIndex = 3;
            this.btnRemoveVehicle.Text = "Remove Vehicle";
            this.btnRemoveVehicle.UseVisualStyleBackColor = true;
            this.btnRemoveVehicle.Click += new System.EventHandler(this.btnRemoveVehicle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(161, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(531, 197);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // btnVehicles
            // 
            this.btnVehicles.Location = new System.Drawing.Point(28, 151);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(106, 23);
            this.btnVehicles.TabIndex = 5;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(586, 325);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(106, 23);
            this.btnSignOut.TabIndex = 6;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnPickUp
            // 
            this.btnPickUp.Location = new System.Drawing.Point(28, 180);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(106, 23);
            this.btnPickUp.TabIndex = 7;
            this.btnPickUp.Text = "Pick Up";
            this.btnPickUp.UseVisualStyleBackColor = true;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // btnMyPassengers
            // 
            this.btnMyPassengers.Location = new System.Drawing.Point(28, 209);
            this.btnMyPassengers.Name = "btnMyPassengers";
            this.btnMyPassengers.Size = new System.Drawing.Size(106, 23);
            this.btnMyPassengers.TabIndex = 8;
            this.btnMyPassengers.Text = "Passengers";
            this.btnMyPassengers.UseVisualStyleBackColor = true;
            this.btnMyPassengers.Click += new System.EventHandler(this.btnMyRiders_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(28, 325);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(106, 23);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin Mode";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRidesCompleted
            // 
            this.btnRidesCompleted.Location = new System.Drawing.Point(28, 238);
            this.btnRidesCompleted.Name = "btnRidesCompleted";
            this.btnRidesCompleted.Size = new System.Drawing.Size(106, 23);
            this.btnRidesCompleted.TabIndex = 10;
            this.btnRidesCompleted.Text = "Rides Completed";
            this.btnRidesCompleted.UseVisualStyleBackColor = true;
            this.btnRidesCompleted.Click += new System.EventHandler(this.btnRideCompleted_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(28, 268);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(106, 23);
            this.btnBalance.TabIndex = 11;
            this.btnBalance.Text = "Current Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnPassengerHome
            // 
            this.btnPassengerHome.Location = new System.Drawing.Point(304, 325);
            this.btnPassengerHome.Name = "btnPassengerHome";
            this.btnPassengerHome.Size = new System.Drawing.Size(106, 23);
            this.btnPassengerHome.TabIndex = 12;
            this.btnPassengerHome.Text = "Passenger Home";
            this.btnPassengerHome.UseVisualStyleBackColor = true;
            this.btnPassengerHome.Click += new System.EventHandler(this.btnPassengerHome_Click);
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 360);
            this.Controls.Add(this.btnPassengerHome);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnRidesCompleted);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnMyPassengers);
            this.Controls.Add(this.btnPickUp);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnVehicles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRemoveVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.btnWaiting);
            this.Controls.Add(this.txtHome);
            this.Name = "Driver";
            this.Text = "Driver Home Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHome;
        private System.Windows.Forms.Button btnWaiting;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnRemoveVehicle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.Button btnMyPassengers;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnRidesCompleted;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnPassengerHome;
    }
}