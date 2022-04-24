
namespace wolfRideApp
{
    partial class AddVehicle
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
            this.txtMake = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtbxMake = new System.Windows.Forms.TextBox();
            this.txtbxModel = new System.Windows.Forms.TextBox();
            this.txtLP = new System.Windows.Forms.Label();
            this.txtbxLP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMake
            // 
            this.txtMake.AutoSize = true;
            this.txtMake.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMake.Location = new System.Drawing.Point(65, 30);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(53, 18);
            this.txtMake.TabIndex = 0;
            this.txtMake.Text = "Make:";
            // 
            // txtModel
            // 
            this.txtModel.AutoSize = true;
            this.txtModel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModel.Location = new System.Drawing.Point(61, 68);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(57, 18);
            this.txtModel.TabIndex = 1;
            this.txtModel.Text = "Model:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(124, 165);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtbxMake
            // 
            this.txtbxMake.Location = new System.Drawing.Point(124, 30);
            this.txtbxMake.Name = "txtbxMake";
            this.txtbxMake.Size = new System.Drawing.Size(173, 23);
            this.txtbxMake.TabIndex = 3;
            // 
            // txtbxModel
            // 
            this.txtbxModel.Location = new System.Drawing.Point(124, 68);
            this.txtbxModel.Name = "txtbxModel";
            this.txtbxModel.Size = new System.Drawing.Size(173, 23);
            this.txtbxModel.TabIndex = 4;
            // 
            // txtLP
            // 
            this.txtLP.AutoSize = true;
            this.txtLP.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLP.Location = new System.Drawing.Point(12, 107);
            this.txtLP.Name = "txtLP";
            this.txtLP.Size = new System.Drawing.Size(106, 18);
            this.txtLP.TabIndex = 5;
            this.txtLP.Text = "License Plate:";
            // 
            // txtbxLP
            // 
            this.txtbxLP.Location = new System.Drawing.Point(124, 107);
            this.txtbxLP.Name = "txtbxLP";
            this.txtbxLP.Size = new System.Drawing.Size(173, 23);
            this.txtbxLP.TabIndex = 6;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 210);
            this.Controls.Add(this.txtbxLP);
            this.Controls.Add(this.txtLP);
            this.Controls.Add(this.txtbxModel);
            this.Controls.Add(this.txtbxMake);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Name = "AddVehicle";
            this.Text = "Add Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMake;
        private System.Windows.Forms.Label txtModel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtbxMake;
        private System.Windows.Forms.TextBox txtbxModel;
        private System.Windows.Forms.Label txtLP;
        private System.Windows.Forms.TextBox txtbxLP;
    }
}