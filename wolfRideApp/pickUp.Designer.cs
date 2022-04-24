
namespace wolfRideApp
{
    partial class pickUp
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
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtPassengers = new System.Windows.Forms.Label();
            this.numericUpDownPassenger = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxDestination = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(144, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(153, 31);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Wolf Ride";
            // 
            // txtPassengers
            // 
            this.txtPassengers.AutoSize = true;
            this.txtPassengers.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassengers.Location = new System.Drawing.Point(12, 90);
            this.txtPassengers.Name = "txtPassengers";
            this.txtPassengers.Size = new System.Drawing.Size(92, 18);
            this.txtPassengers.TabIndex = 1;
            this.txtPassengers.Text = "Passengers:";
            // 
            // numericUpDownPassenger
            // 
            this.numericUpDownPassenger.Location = new System.Drawing.Point(110, 91);
            this.numericUpDownPassenger.Name = "numericUpDownPassenger";
            this.numericUpDownPassenger.Size = new System.Drawing.Size(86, 23);
            this.numericUpDownPassenger.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination:";
            // 
            // txtbxDestination
            // 
            this.txtbxDestination.Location = new System.Drawing.Point(112, 134);
            this.txtbxDestination.Name = "txtbxDestination";
            this.txtbxDestination.Size = new System.Drawing.Size(243, 23);
            this.txtbxDestination.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(170, 205);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 250);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbxDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownPassenger);
            this.Controls.Add(this.txtPassengers);
            this.Controls.Add(this.txtTitle);
            this.Name = "pickUp";
            this.Text = "Ride";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassenger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label txtPassengers;
        private System.Windows.Forms.NumericUpDown numericUpDownPassenger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxDestination;
        private System.Windows.Forms.Button btnSubmit;
    }
}