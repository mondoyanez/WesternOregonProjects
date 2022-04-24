
namespace wolfRideApp
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTitle = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDriverRequest = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnViewVehicles = new System.Windows.Forms.Button();
            this.btnPassengers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.btnMakeDriver = new System.Windows.Forms.Button();
            this.btnMakeAdmin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTerminationRequests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(270, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(199, 31);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Admin Home";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(197, 78);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(412, 201);
            this.dataGridView.TabIndex = 1;
            // 
            // btnDriverRequest
            // 
            this.btnDriverRequest.Location = new System.Drawing.Point(47, 324);
            this.btnDriverRequest.Name = "btnDriverRequest";
            this.btnDriverRequest.Size = new System.Drawing.Size(152, 23);
            this.btnDriverRequest.TabIndex = 2;
            this.btnDriverRequest.Text = "View Driver Requests";
            this.btnDriverRequest.UseVisualStyleBackColor = true;
            this.btnDriverRequest.Click += new System.EventHandler(this.btnDriverRequest_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Location = new System.Drawing.Point(47, 392);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(152, 23);
            this.btnDrivers.TabIndex = 3;
            this.btnDrivers.Text = "View Drivers";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnViewVehicles
            // 
            this.btnViewVehicles.Location = new System.Drawing.Point(47, 457);
            this.btnViewVehicles.Name = "btnViewVehicles";
            this.btnViewVehicles.Size = new System.Drawing.Size(152, 23);
            this.btnViewVehicles.TabIndex = 4;
            this.btnViewVehicles.Text = "View Vehicles";
            this.btnViewVehicles.UseVisualStyleBackColor = true;
            this.btnViewVehicles.Click += new System.EventHandler(this.btnViewVehicles_Click);
            // 
            // btnPassengers
            // 
            this.btnPassengers.Location = new System.Drawing.Point(234, 324);
            this.btnPassengers.Name = "btnPassengers";
            this.btnPassengers.Size = new System.Drawing.Size(152, 23);
            this.btnPassengers.TabIndex = 5;
            this.btnPassengers.Text = "View Passengers";
            this.btnPassengers.UseVisualStyleBackColor = true;
            this.btnPassengers.Click += new System.EventHandler(this.btnPassengers_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(234, 392);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(152, 23);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "View All Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.Location = new System.Drawing.Point(234, 457);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(152, 23);
            this.btnAdmins.TabIndex = 7;
            this.btnAdmins.Text = "View Admins";
            this.btnAdmins.UseVisualStyleBackColor = true;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.Location = new System.Drawing.Point(423, 324);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(152, 23);
            this.btnMessages.TabIndex = 8;
            this.btnMessages.Text = "View Messages";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(423, 457);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(152, 23);
            this.btnTerminate.TabIndex = 9;
            this.btnTerminate.Text = "Terminate User";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // btnMakeDriver
            // 
            this.btnMakeDriver.Location = new System.Drawing.Point(610, 324);
            this.btnMakeDriver.Name = "btnMakeDriver";
            this.btnMakeDriver.Size = new System.Drawing.Size(152, 23);
            this.btnMakeDriver.TabIndex = 10;
            this.btnMakeDriver.Text = "Make User Driver";
            this.btnMakeDriver.UseVisualStyleBackColor = true;
            this.btnMakeDriver.Click += new System.EventHandler(this.btnMakeDriver_Click);
            // 
            // btnMakeAdmin
            // 
            this.btnMakeAdmin.Location = new System.Drawing.Point(610, 392);
            this.btnMakeAdmin.Name = "btnMakeAdmin";
            this.btnMakeAdmin.Size = new System.Drawing.Size(152, 23);
            this.btnMakeAdmin.TabIndex = 11;
            this.btnMakeAdmin.Text = "Make User Admin";
            this.btnMakeAdmin.UseVisualStyleBackColor = true;
            this.btnMakeAdmin.Click += new System.EventHandler(this.btnMakeAdmin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(610, 457);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 23);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTerminationRequests
            // 
            this.btnTerminationRequests.Location = new System.Drawing.Point(423, 392);
            this.btnTerminationRequests.Name = "btnTerminationRequests";
            this.btnTerminationRequests.Size = new System.Drawing.Size(152, 23);
            this.btnTerminationRequests.TabIndex = 13;
            this.btnTerminationRequests.Text = "View Termination Request";
            this.btnTerminationRequests.UseVisualStyleBackColor = true;
            this.btnTerminationRequests.Click += new System.EventHandler(this.btnTerminationRequests_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 511);
            this.Controls.Add(this.btnTerminationRequests);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMakeAdmin);
            this.Controls.Add(this.btnMakeDriver);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.btnAdmins);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnPassengers);
            this.Controls.Add(this.btnViewVehicles);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.btnDriverRequest);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtTitle);
            this.Name = "Admin";
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDriverRequest;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnViewVehicles;
        private System.Windows.Forms.Button btnPassengers;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Button btnMakeDriver;
        private System.Windows.Forms.Button btnMakeAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTerminationRequests;
    }
}