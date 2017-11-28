namespace MedClerk.Views
{
    partial class PatientProfileView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientProfileView));
            this.dtp_prescriptionEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_patientPrescriptions = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_testHistory = new System.Windows.Forms.Label();
            this.btn_PrintSelectedTest = new System.Windows.Forms.Button();
            this.btn_ExtendSelectedPrescription = new System.Windows.Forms.Button();
            this.lbl_formHeading = new System.Windows.Forms.Label();
            this.lbl_prescriptionsTitle = new System.Windows.Forms.Label();
            this.lbl_patientId = new System.Windows.Forms.Label();
            this.lbl_patientDob = new System.Windows.Forms.Label();
            this.lbl_patientName = new System.Windows.Forms.Label();
            this.lbl_patientAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patientPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_prescriptionEndDate
            // 
            this.dtp_prescriptionEndDate.Location = new System.Drawing.Point(12, 189);
            this.dtp_prescriptionEndDate.Name = "dtp_prescriptionEndDate";
            this.dtp_prescriptionEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_prescriptionEndDate.TabIndex = 2;
            // 
            // dgv_patientPrescriptions
            // 
            this.dgv_patientPrescriptions.AllowUserToAddRows = false;
            this.dgv_patientPrescriptions.AllowUserToDeleteRows = false;
            this.dgv_patientPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patientPrescriptions.Location = new System.Drawing.Point(12, 216);
            this.dgv_patientPrescriptions.Name = "dgv_patientPrescriptions";
            this.dgv_patientPrescriptions.ReadOnly = true;
            this.dgv_patientPrescriptions.Size = new System.Drawing.Size(663, 140);
            this.dgv_patientPrescriptions.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 395);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(663, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // lbl_testHistory
            // 
            this.lbl_testHistory.AutoSize = true;
            this.lbl_testHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_testHistory.Location = new System.Drawing.Point(12, 372);
            this.lbl_testHistory.Name = "lbl_testHistory";
            this.lbl_testHistory.Size = new System.Drawing.Size(167, 20);
            this.lbl_testHistory.TabIndex = 5;
            this.lbl_testHistory.Text = "Patient Test History";
            // 
            // btn_PrintSelectedTest
            // 
            this.btn_PrintSelectedTest.Location = new System.Drawing.Point(601, 369);
            this.btn_PrintSelectedTest.Name = "btn_PrintSelectedTest";
            this.btn_PrintSelectedTest.Size = new System.Drawing.Size(75, 23);
            this.btn_PrintSelectedTest.TabIndex = 6;
            this.btn_PrintSelectedTest.Text = "Print";
            this.btn_PrintSelectedTest.UseVisualStyleBackColor = true;
            // 
            // btn_ExtendSelectedPrescription
            // 
            this.btn_ExtendSelectedPrescription.Location = new System.Drawing.Point(600, 190);
            this.btn_ExtendSelectedPrescription.Name = "btn_ExtendSelectedPrescription";
            this.btn_ExtendSelectedPrescription.Size = new System.Drawing.Size(75, 23);
            this.btn_ExtendSelectedPrescription.TabIndex = 7;
            this.btn_ExtendSelectedPrescription.Text = "Extend";
            this.btn_ExtendSelectedPrescription.UseVisualStyleBackColor = true;
            // 
            // lbl_formHeading
            // 
            this.lbl_formHeading.AutoSize = true;
            this.lbl_formHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_formHeading.Location = new System.Drawing.Point(8, 9);
            this.lbl_formHeading.Name = "lbl_formHeading";
            this.lbl_formHeading.Size = new System.Drawing.Size(122, 20);
            this.lbl_formHeading.TabIndex = 8;
            this.lbl_formHeading.Text = "Patient Profile";
            // 
            // lbl_prescriptionsTitle
            // 
            this.lbl_prescriptionsTitle.AutoSize = true;
            this.lbl_prescriptionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_prescriptionsTitle.Location = new System.Drawing.Point(8, 166);
            this.lbl_prescriptionsTitle.Name = "lbl_prescriptionsTitle";
            this.lbl_prescriptionsTitle.Size = new System.Drawing.Size(175, 20);
            this.lbl_prescriptionsTitle.TabIndex = 9;
            this.lbl_prescriptionsTitle.Text = "Patient Prescriptions";
            // 
            // lbl_patientId
            // 
            this.lbl_patientId.AutoSize = true;
            this.lbl_patientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientId.Location = new System.Drawing.Point(13, 50);
            this.lbl_patientId.Name = "lbl_patientId";
            this.lbl_patientId.Size = new System.Drawing.Size(90, 16);
            this.lbl_patientId.TabIndex = 10;
            this.lbl_patientId.Text = "<patient ID>";
            // 
            // lbl_patientDob
            // 
            this.lbl_patientDob.AutoSize = true;
            this.lbl_patientDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientDob.Location = new System.Drawing.Point(215, 50);
            this.lbl_patientDob.Name = "lbl_patientDob";
            this.lbl_patientDob.Size = new System.Drawing.Size(102, 16);
            this.lbl_patientDob.TabIndex = 11;
            this.lbl_patientDob.Text = "<patient dob>";
            // 
            // lbl_patientName
            // 
            this.lbl_patientName.AutoSize = true;
            this.lbl_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientName.Location = new System.Drawing.Point(13, 90);
            this.lbl_patientName.Name = "lbl_patientName";
            this.lbl_patientName.Size = new System.Drawing.Size(113, 16);
            this.lbl_patientName.TabIndex = 12;
            this.lbl_patientName.Text = "<patient name>";
            // 
            // lbl_patientAddress
            // 
            this.lbl_patientAddress.AutoSize = true;
            this.lbl_patientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientAddress.Location = new System.Drawing.Point(215, 90);
            this.lbl_patientAddress.Name = "lbl_patientAddress";
            this.lbl_patientAddress.Size = new System.Drawing.Size(132, 16);
            this.lbl_patientAddress.TabIndex = 13;
            this.lbl_patientAddress.Text = "<patient address>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select a prescription from the list, set the the new end date, and click \'Extend\'" +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select a test result and click the \'Print\' button";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(524, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 152);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // PatientProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_patientAddress);
            this.Controls.Add(this.lbl_patientName);
            this.Controls.Add(this.lbl_patientDob);
            this.Controls.Add(this.lbl_patientId);
            this.Controls.Add(this.lbl_prescriptionsTitle);
            this.Controls.Add(this.lbl_formHeading);
            this.Controls.Add(this.btn_ExtendSelectedPrescription);
            this.Controls.Add(this.btn_PrintSelectedTest);
            this.Controls.Add(this.lbl_testHistory);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgv_patientPrescriptions);
            this.Controls.Add(this.dtp_prescriptionEndDate);
            this.MinimumSize = new System.Drawing.Size(704, 521);
            this.Name = "PatientProfileView";
            this.Text = "PatientProfileView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patientPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_prescriptionEndDate;
        private System.Windows.Forms.DataGridView dgv_patientPrescriptions;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_testHistory;
        private System.Windows.Forms.Button btn_PrintSelectedTest;
        private System.Windows.Forms.Button btn_ExtendSelectedPrescription;
        private System.Windows.Forms.Label lbl_formHeading;
        private System.Windows.Forms.Label lbl_prescriptionsTitle;
        private System.Windows.Forms.Label lbl_patientId;
        private System.Windows.Forms.Label lbl_patientDob;
        private System.Windows.Forms.Label lbl_patientName;
        private System.Windows.Forms.Label lbl_patientAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}