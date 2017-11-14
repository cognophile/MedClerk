namespace MedClerk.Views
{
    partial class AppointmentManagementView
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
            this.menuBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mandatoryLbl1 = new System.Windows.Forms.Label();
            this.staffNameCB = new System.Windows.Forms.ComboBox();
            this.staffMemberLbl = new System.Windows.Forms.Label();
            this.appointmentSelectLB = new System.Windows.Forms.ListBox();
            this.patientIDTB = new System.Windows.Forms.TextBox();
            this.mandatoryLbl2 = new System.Windows.Forms.Label();
            this.staffIDCB = new System.Windows.Forms.ComboBox();
            this.mandatoryLbl3 = new System.Windows.Forms.Label();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.mandatoryLbl4 = new System.Windows.Forms.Label();
            this.explainationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Location = new System.Drawing.Point(14, 435);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(94, 35);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(454, 435);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 35);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(580, 435);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 35);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Appointments";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 60);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // mandatoryLbl1
            // 
            this.mandatoryLbl1.AutoSize = true;
            this.mandatoryLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryLbl1.Location = new System.Drawing.Point(159, 60);
            this.mandatoryLbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mandatoryLbl1.Name = "mandatoryLbl1";
            this.mandatoryLbl1.Size = new System.Drawing.Size(13, 17);
            this.mandatoryLbl1.TabIndex = 5;
            this.mandatoryLbl1.Text = "*";
            // 
            // staffNameCB
            // 
            this.staffNameCB.FormattingEnabled = true;
            this.staffNameCB.Location = new System.Drawing.Point(231, 60);
            this.staffNameCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staffNameCB.Name = "staffNameCB";
            this.staffNameCB.Size = new System.Drawing.Size(124, 21);
            this.staffNameCB.TabIndex = 6;
            // 
            // staffMemberLbl
            // 
            this.staffMemberLbl.AutoSize = true;
            this.staffMemberLbl.Location = new System.Drawing.Point(364, 63);
            this.staffMemberLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffMemberLbl.Name = "staffMemberLbl";
            this.staffMemberLbl.Size = new System.Drawing.Size(69, 13);
            this.staffMemberLbl.TabIndex = 7;
            this.staffMemberLbl.Text = "Staff member";
            // 
            // appointmentSelectLB
            // 
            this.appointmentSelectLB.FormattingEnabled = true;
            this.appointmentSelectLB.Location = new System.Drawing.Point(24, 109);
            this.appointmentSelectLB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentSelectLB.Name = "appointmentSelectLB";
            this.appointmentSelectLB.Size = new System.Drawing.Size(330, 108);
            this.appointmentSelectLB.TabIndex = 8;
            // 
            // patientIDTB
            // 
            this.patientIDTB.Location = new System.Drawing.Point(24, 241);
            this.patientIDTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientIDTB.Name = "patientIDTB";
            this.patientIDTB.Size = new System.Drawing.Size(132, 20);
            this.patientIDTB.TabIndex = 9;
            this.patientIDTB.Text = "Patient ID";
            // 
            // mandatoryLbl2
            // 
            this.mandatoryLbl2.AutoSize = true;
            this.mandatoryLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryLbl2.Location = new System.Drawing.Point(158, 241);
            this.mandatoryLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mandatoryLbl2.Name = "mandatoryLbl2";
            this.mandatoryLbl2.Size = new System.Drawing.Size(13, 17);
            this.mandatoryLbl2.TabIndex = 10;
            this.mandatoryLbl2.Text = "*";
            // 
            // staffIDCB
            // 
            this.staffIDCB.FormattingEnabled = true;
            this.staffIDCB.Location = new System.Drawing.Point(24, 269);
            this.staffIDCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staffIDCB.Name = "staffIDCB";
            this.staffIDCB.Size = new System.Drawing.Size(132, 21);
            this.staffIDCB.TabIndex = 11;
            // 
            // mandatoryLbl3
            // 
            this.mandatoryLbl3.AutoSize = true;
            this.mandatoryLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryLbl3.Location = new System.Drawing.Point(158, 270);
            this.mandatoryLbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mandatoryLbl3.Name = "mandatoryLbl3";
            this.mandatoryLbl3.Size = new System.Drawing.Size(13, 17);
            this.mandatoryLbl3.TabIndex = 12;
            this.mandatoryLbl3.Text = "*";
            // 
            // timeTB
            // 
            this.timeTB.Location = new System.Drawing.Point(24, 304);
            this.timeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(132, 20);
            this.timeTB.TabIndex = 13;
            this.timeTB.Text = "Time";
            // 
            // mandatoryLbl4
            // 
            this.mandatoryLbl4.AutoSize = true;
            this.mandatoryLbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatoryLbl4.Location = new System.Drawing.Point(158, 304);
            this.mandatoryLbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mandatoryLbl4.Name = "mandatoryLbl4";
            this.mandatoryLbl4.Size = new System.Drawing.Size(13, 17);
            this.mandatoryLbl4.TabIndex = 14;
            this.mandatoryLbl4.Text = "*";
            // 
            // explainationLbl
            // 
            this.explainationLbl.AutoSize = true;
            this.explainationLbl.Location = new System.Drawing.Point(173, 25);
            this.explainationLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.explainationLbl.Name = "explainationLbl";
            this.explainationLbl.Size = new System.Drawing.Size(73, 13);
            this.explainationLbl.TabIndex = 15;
            this.explainationLbl.Text = "* = Mandatory";
            // 
            // AppointmentManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 483);
            this.Controls.Add(this.explainationLbl);
            this.Controls.Add(this.mandatoryLbl4);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.mandatoryLbl3);
            this.Controls.Add(this.staffIDCB);
            this.Controls.Add(this.mandatoryLbl2);
            this.Controls.Add(this.patientIDTB);
            this.Controls.Add(this.appointmentSelectLB);
            this.Controls.Add(this.staffMemberLbl);
            this.Controls.Add(this.staffNameCB);
            this.Controls.Add(this.mandatoryLbl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.menuBtn);
            this.Name = "AppointmentManagementView";
            this.Text = "AppointmentManagementView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label mandatoryLbl1;
        private System.Windows.Forms.ComboBox staffNameCB;
        private System.Windows.Forms.Label staffMemberLbl;
        private System.Windows.Forms.ListBox appointmentSelectLB;
        private System.Windows.Forms.TextBox patientIDTB;
        private System.Windows.Forms.Label mandatoryLbl2;
        private System.Windows.Forms.ComboBox staffIDCB;
        private System.Windows.Forms.Label mandatoryLbl3;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Label mandatoryLbl4;
        private System.Windows.Forms.Label explainationLbl;
    }
}