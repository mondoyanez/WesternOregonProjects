
namespace wolfRideApp
{
    partial class PickUpPassenger
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
            this.txtID = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLP = new System.Windows.Forms.Label();
            this.txtbxLP = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(33, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(318, 43);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Enter the ride number and the license plate of the vehicle that you are going to " +
    "take";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(24, 64);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(108, 18);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Ride Number:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(151, 170);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLP
            // 
            this.txtLP.AutoSize = true;
            this.txtLP.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLP.Location = new System.Drawing.Point(26, 112);
            this.txtLP.Name = "txtLP";
            this.txtLP.Size = new System.Drawing.Size(106, 18);
            this.txtLP.TabIndex = 4;
            this.txtLP.Text = "License Plate:";
            // 
            // txtbxLP
            // 
            this.txtbxLP.Location = new System.Drawing.Point(138, 112);
            this.txtbxLP.Name = "txtbxLP";
            this.txtbxLP.Size = new System.Drawing.Size(141, 23);
            this.txtbxLP.TabIndex = 5;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(138, 65);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(141, 23);
            this.numericUpDown.TabIndex = 6;
            // 
            // PickUpPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 205);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.txtbxLP);
            this.Controls.Add(this.txtLP);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTitle);
            this.Name = "PickUpPassenger";
            this.Text = "Pick Up Passenger";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label txtLP;
        private System.Windows.Forms.TextBox txtbxLP;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}