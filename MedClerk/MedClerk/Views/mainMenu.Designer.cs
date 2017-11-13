namespace MedClerk.Views
{
    partial class MainMenu
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
            this.businessLabel = new System.Windows.Forms.Label();
            this.staffBtn = new System.Windows.Forms.Button();
            this.patientsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.appBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // businessLabel
            // 
            this.businessLabel.AutoSize = true;
            this.businessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessLabel.Location = new System.Drawing.Point(237, 48);
            this.businessLabel.Name = "businessLabel";
            this.businessLabel.Size = new System.Drawing.Size(205, 37);
            this.businessLabel.TabIndex = 0;
            this.businessLabel.Text = "Over Surgery";
            // 
            // staffBtn
            // 
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(44, 138);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(195, 54);
            this.staffBtn.TabIndex = 1;
            this.staffBtn.Text = "Staff";
            this.staffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // patientsBtn
            // 
            this.patientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsBtn.Location = new System.Drawing.Point(44, 219);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Size = new System.Drawing.Size(195, 54);
            this.patientsBtn.TabIndex = 2;
            this.patientsBtn.Text = "Patients";
            this.patientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(426, 219);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(195, 54);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // appBtn
            // 
            this.appBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appBtn.Location = new System.Drawing.Point(426, 138);
            this.appBtn.Name = "appBtn";
            this.appBtn.Size = new System.Drawing.Size(195, 54);
            this.appBtn.TabIndex = 4;
            this.appBtn.Text = "Appointments";
            this.appBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 385);
            this.Controls.Add(this.appBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.patientsBtn);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.businessLabel);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label businessLabel;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button patientsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button appBtn;
    }
}