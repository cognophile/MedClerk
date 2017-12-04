namespace MedClerk.Views
{
    partial class PatientManagementView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientManagementView));
            this.btn_OpenMenu = new System.Windows.Forms.Button();
            this.btn_SearchPatients = new System.Windows.Forms.Button();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.lbl_patientsManagementTitle = new System.Windows.Forms.Label();
            this.txtbx_AddNameField = new System.Windows.Forms.TextBox();
            this.txtbx_AddAddressField = new System.Windows.Forms.TextBox();
            this.lbl_AddName = new System.Windows.Forms.Label();
            this.lbl_AddAddress = new System.Windows.Forms.Label();
            this.lbl_AddDob = new System.Windows.Forms.Label();
            this.dGrid_SearchPatientResults = new System.Windows.Forms.DataGridView();
            this.lbl_SearchPatientNameField = new System.Windows.Forms.Label();
            this.lbl_SearchAddess = new System.Windows.Forms.Label();
            this.lbl_SearchPatientId = new System.Windows.Forms.Label();
            this.txtbx_SearchNameField = new System.Windows.Forms.TextBox();
            this.txtbx_SearchAddressField = new System.Windows.Forms.TextBox();
            this.txtbx_SearchIdField = new System.Windows.Forms.TextBox();
            this.lbl_SearchDob = new System.Windows.Forms.Label();
            this.lbl_SearchPatientsTitle = new System.Windows.Forms.Label();
            this.lbl_patientsManagementInstructions = new System.Windows.Forms.Label();
            this.lbl_SearchPatientsInstructions = new System.Windows.Forms.Label();
            this.btn_ViewPatientProfile = new System.Windows.Forms.Button();
            this.dtp_AddDobSelector = new System.Windows.Forms.DateTimePicker();
            this.dtp_SearchDobSelector = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_SearchPatientResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OpenMenu
            // 
            this.btn_OpenMenu.Location = new System.Drawing.Point(13, 448);
            this.btn_OpenMenu.Name = "btn_OpenMenu";
            this.btn_OpenMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenMenu.TabIndex = 10;
            this.btn_OpenMenu.Text = "Menu";
            this.btn_OpenMenu.UseVisualStyleBackColor = true;
            this.btn_OpenMenu.Click += new System.EventHandler(this.btn_OpenMenu_Click);
            // 
            // btn_SearchPatients
            // 
            this.btn_SearchPatients.Location = new System.Drawing.Point(603, 192);
            this.btn_SearchPatients.Name = "btn_SearchPatients";
            this.btn_SearchPatients.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchPatients.TabIndex = 8;
            this.btn_SearchPatients.Text = "Search";
            this.btn_SearchPatients.UseVisualStyleBackColor = true;
            this.btn_SearchPatients.Click += new System.EventHandler(this.btn_SearchPatients_Click);
            // 
            // btn_AddPatient
            // 
            this.btn_AddPatient.Location = new System.Drawing.Point(603, 83);
            this.btn_AddPatient.Name = "btn_AddPatient";
            this.btn_AddPatient.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPatient.TabIndex = 3;
            this.btn_AddPatient.Text = "Add";
            this.btn_AddPatient.UseVisualStyleBackColor = true;
            this.btn_AddPatient.Click += new System.EventHandler(this.btn_AddPatient_Click);
            // 
            // lbl_patientsManagementTitle
            // 
            this.lbl_patientsManagementTitle.AutoSize = true;
            this.lbl_patientsManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientsManagementTitle.Location = new System.Drawing.Point(13, 13);
            this.lbl_patientsManagementTitle.Name = "lbl_patientsManagementTitle";
            this.lbl_patientsManagementTitle.Size = new System.Drawing.Size(226, 20);
            this.lbl_patientsManagementTitle.TabIndex = 4;
            this.lbl_patientsManagementTitle.Text = "Patients Management: Add";
            // 
            // txtbx_AddNameField
            // 
            this.txtbx_AddNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_AddNameField.Location = new System.Drawing.Point(80, 54);
            this.txtbx_AddNameField.Name = "txtbx_AddNameField";
            this.txtbx_AddNameField.Size = new System.Drawing.Size(181, 20);
            this.txtbx_AddNameField.TabIndex = 0;
            this.txtbx_AddNameField.Text = "- Enter full name -";
            // 
            // txtbx_AddAddressField
            // 
            this.txtbx_AddAddressField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_AddAddressField.Location = new System.Drawing.Point(329, 54);
            this.txtbx_AddAddressField.Name = "txtbx_AddAddressField";
            this.txtbx_AddAddressField.Size = new System.Drawing.Size(349, 20);
            this.txtbx_AddAddressField.TabIndex = 1;
            this.txtbx_AddAddressField.Text = "- Enter full address -";
            // 
            // lbl_AddName
            // 
            this.lbl_AddName.AutoSize = true;
            this.lbl_AddName.Location = new System.Drawing.Point(15, 57);
            this.lbl_AddName.Name = "lbl_AddName";
            this.lbl_AddName.Size = new System.Drawing.Size(35, 13);
            this.lbl_AddName.TabIndex = 9;
            this.lbl_AddName.Text = "Name";
            // 
            // lbl_AddAddress
            // 
            this.lbl_AddAddress.AutoSize = true;
            this.lbl_AddAddress.Location = new System.Drawing.Point(278, 57);
            this.lbl_AddAddress.Name = "lbl_AddAddress";
            this.lbl_AddAddress.Size = new System.Drawing.Size(45, 13);
            this.lbl_AddAddress.TabIndex = 10;
            this.lbl_AddAddress.Text = "Address";
            // 
            // lbl_AddDob
            // 
            this.lbl_AddDob.AutoSize = true;
            this.lbl_AddDob.Location = new System.Drawing.Point(15, 83);
            this.lbl_AddDob.Name = "lbl_AddDob";
            this.lbl_AddDob.Size = new System.Drawing.Size(30, 13);
            this.lbl_AddDob.TabIndex = 11;
            this.lbl_AddDob.Text = "DOB";
            // 
            // dGrid_SearchPatientResults
            // 
            this.dGrid_SearchPatientResults.AllowUserToAddRows = false;
            this.dGrid_SearchPatientResults.AllowUserToDeleteRows = false;
            this.dGrid_SearchPatientResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_SearchPatientResults.Location = new System.Drawing.Point(13, 251);
            this.dGrid_SearchPatientResults.Name = "dGrid_SearchPatientResults";
            this.dGrid_SearchPatientResults.ReadOnly = true;
            this.dGrid_SearchPatientResults.Size = new System.Drawing.Size(663, 191);
            this.dGrid_SearchPatientResults.TabIndex = 12;
            // 
            // lbl_SearchPatientNameField
            // 
            this.lbl_SearchPatientNameField.AutoSize = true;
            this.lbl_SearchPatientNameField.Location = new System.Drawing.Point(15, 228);
            this.lbl_SearchPatientNameField.Name = "lbl_SearchPatientNameField";
            this.lbl_SearchPatientNameField.Size = new System.Drawing.Size(35, 13);
            this.lbl_SearchPatientNameField.TabIndex = 18;
            this.lbl_SearchPatientNameField.Text = "Name";
            // 
            // lbl_SearchAddess
            // 
            this.lbl_SearchAddess.AutoSize = true;
            this.lbl_SearchAddess.Location = new System.Drawing.Point(278, 228);
            this.lbl_SearchAddess.Name = "lbl_SearchAddess";
            this.lbl_SearchAddess.Size = new System.Drawing.Size(45, 13);
            this.lbl_SearchAddess.TabIndex = 17;
            this.lbl_SearchAddess.Text = "Address";
            // 
            // lbl_SearchPatientId
            // 
            this.lbl_SearchPatientId.AutoSize = true;
            this.lbl_SearchPatientId.Location = new System.Drawing.Point(15, 202);
            this.lbl_SearchPatientId.Name = "lbl_SearchPatientId";
            this.lbl_SearchPatientId.Size = new System.Drawing.Size(18, 13);
            this.lbl_SearchPatientId.TabIndex = 16;
            this.lbl_SearchPatientId.Text = "ID";
            // 
            // txtbx_SearchNameField
            // 
            this.txtbx_SearchNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_SearchNameField.Location = new System.Drawing.Point(80, 225);
            this.txtbx_SearchNameField.Name = "txtbx_SearchNameField";
            this.txtbx_SearchNameField.Size = new System.Drawing.Size(183, 20);
            this.txtbx_SearchNameField.TabIndex = 5;
            // 
            // txtbx_SearchAddressField
            // 
            this.txtbx_SearchAddressField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_SearchAddressField.Location = new System.Drawing.Point(329, 225);
            this.txtbx_SearchAddressField.Name = "txtbx_SearchAddressField";
            this.txtbx_SearchAddressField.Size = new System.Drawing.Size(349, 20);
            this.txtbx_SearchAddressField.TabIndex = 6;
            // 
            // txtbx_SearchIdField
            // 
            this.txtbx_SearchIdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_SearchIdField.Location = new System.Drawing.Point(80, 199);
            this.txtbx_SearchIdField.Name = "txtbx_SearchIdField";
            this.txtbx_SearchIdField.Size = new System.Drawing.Size(65, 20);
            this.txtbx_SearchIdField.TabIndex = 4;
            // 
            // lbl_SearchDob
            // 
            this.lbl_SearchDob.AutoSize = true;
            this.lbl_SearchDob.Location = new System.Drawing.Point(278, 202);
            this.lbl_SearchDob.Name = "lbl_SearchDob";
            this.lbl_SearchDob.Size = new System.Drawing.Size(30, 13);
            this.lbl_SearchDob.TabIndex = 20;
            this.lbl_SearchDob.Text = "DOB";
            // 
            // lbl_SearchPatientsTitle
            // 
            this.lbl_SearchPatientsTitle.AutoSize = true;
            this.lbl_SearchPatientsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchPatientsTitle.Location = new System.Drawing.Point(12, 140);
            this.lbl_SearchPatientsTitle.Name = "lbl_SearchPatientsTitle";
            this.lbl_SearchPatientsTitle.Size = new System.Drawing.Size(590, 20);
            this.lbl_SearchPatientsTitle.TabIndex = 21;
            this.lbl_SearchPatientsTitle.Text = "Patients Management: Search and Profile View (Tests and Prescriptions)";
            // 
            // lbl_patientsManagementInstructions
            // 
            this.lbl_patientsManagementInstructions.AutoSize = true;
            this.lbl_patientsManagementInstructions.Location = new System.Drawing.Point(14, 33);
            this.lbl_patientsManagementInstructions.Name = "lbl_patientsManagementInstructions";
            this.lbl_patientsManagementInstructions.Size = new System.Drawing.Size(256, 13);
            this.lbl_patientsManagementInstructions.TabIndex = 22;
            this.lbl_patientsManagementInstructions.Text = "To add a new patient, fill out all required fields below.";
            // 
            // lbl_SearchPatientsInstructions
            // 
            this.lbl_SearchPatientsInstructions.AutoSize = true;
            this.lbl_SearchPatientsInstructions.Location = new System.Drawing.Point(12, 163);
            this.lbl_SearchPatientsInstructions.MaximumSize = new System.Drawing.Size(650, 0);
            this.lbl_SearchPatientsInstructions.Name = "lbl_SearchPatientsInstructions";
            this.lbl_SearchPatientsInstructions.Size = new System.Drawing.Size(646, 26);
            this.lbl_SearchPatientsInstructions.TabIndex = 23;
            this.lbl_SearchPatientsInstructions.Text = resources.GetString("lbl_SearchPatientsInstructions.Text");
            // 
            // btn_ViewPatientProfile
            // 
            this.btn_ViewPatientProfile.Location = new System.Drawing.Point(603, 448);
            this.btn_ViewPatientProfile.Name = "btn_ViewPatientProfile";
            this.btn_ViewPatientProfile.Size = new System.Drawing.Size(75, 23);
            this.btn_ViewPatientProfile.TabIndex = 9;
            this.btn_ViewPatientProfile.Text = "View Profile";
            this.btn_ViewPatientProfile.UseVisualStyleBackColor = true;
            this.btn_ViewPatientProfile.Click += new System.EventHandler(this.btn_ViewPatientProfile_Click);
            // 
            // dtp_AddDobSelector
            // 
            this.dtp_AddDobSelector.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_AddDobSelector.Location = new System.Drawing.Point(80, 83);
            this.dtp_AddDobSelector.Name = "dtp_AddDobSelector";
            this.dtp_AddDobSelector.Size = new System.Drawing.Size(181, 20);
            this.dtp_AddDobSelector.TabIndex = 2;
            this.dtp_AddDobSelector.Value = new System.DateTime(2017, 11, 20, 17, 59, 47, 0);
            // 
            // dtp_SearchDobSelector
            // 
            this.dtp_SearchDobSelector.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_SearchDobSelector.Location = new System.Drawing.Point(329, 199);
            this.dtp_SearchDobSelector.Name = "dtp_SearchDobSelector";
            this.dtp_SearchDobSelector.Size = new System.Drawing.Size(181, 20);
            this.dtp_SearchDobSelector.TabIndex = 7;
            this.dtp_SearchDobSelector.Value = new System.DateTime(2017, 11, 20, 17, 59, 47, 0);
            // 
            // PatientManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(688, 483);
            this.Controls.Add(this.dtp_SearchDobSelector);
            this.Controls.Add(this.dtp_AddDobSelector);
            this.Controls.Add(this.btn_ViewPatientProfile);
            this.Controls.Add(this.lbl_SearchPatientsInstructions);
            this.Controls.Add(this.lbl_patientsManagementInstructions);
            this.Controls.Add(this.lbl_SearchPatientsTitle);
            this.Controls.Add(this.lbl_SearchDob);
            this.Controls.Add(this.lbl_SearchPatientNameField);
            this.Controls.Add(this.lbl_SearchAddess);
            this.Controls.Add(this.lbl_SearchPatientId);
            this.Controls.Add(this.txtbx_SearchNameField);
            this.Controls.Add(this.txtbx_SearchAddressField);
            this.Controls.Add(this.txtbx_SearchIdField);
            this.Controls.Add(this.dGrid_SearchPatientResults);
            this.Controls.Add(this.lbl_AddDob);
            this.Controls.Add(this.lbl_AddAddress);
            this.Controls.Add(this.lbl_AddName);
            this.Controls.Add(this.txtbx_AddAddressField);
            this.Controls.Add(this.txtbx_AddNameField);
            this.Controls.Add(this.lbl_patientsManagementTitle);
            this.Controls.Add(this.btn_AddPatient);
            this.Controls.Add(this.btn_SearchPatients);
            this.Controls.Add(this.btn_OpenMenu);
            this.Name = "PatientManagementView";
            this.Text = "Patient Management";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_SearchPatientResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenMenu;
        private System.Windows.Forms.Button btn_SearchPatients;
        private System.Windows.Forms.Button btn_AddPatient;
        private System.Windows.Forms.Label lbl_patientsManagementTitle;
        private System.Windows.Forms.TextBox txtbx_AddNameField;
        private System.Windows.Forms.TextBox txtbx_AddAddressField;
        private System.Windows.Forms.Label lbl_AddName;
        private System.Windows.Forms.Label lbl_AddAddress;
        private System.Windows.Forms.Label lbl_AddDob;
        private System.Windows.Forms.DataGridView dGrid_SearchPatientResults;
        private System.Windows.Forms.Label lbl_SearchPatientNameField;
        private System.Windows.Forms.Label lbl_SearchAddess;
        private System.Windows.Forms.Label lbl_SearchPatientId;
        private System.Windows.Forms.TextBox txtbx_SearchNameField;
        private System.Windows.Forms.TextBox txtbx_SearchAddressField;
        private System.Windows.Forms.TextBox txtbx_SearchIdField;
        private System.Windows.Forms.Label lbl_SearchDob;
        private System.Windows.Forms.Label lbl_SearchPatientsTitle;
        private System.Windows.Forms.Label lbl_patientsManagementInstructions;
        private System.Windows.Forms.Label lbl_SearchPatientsInstructions;
        private System.Windows.Forms.Button btn_ViewPatientProfile;
        private System.Windows.Forms.DateTimePicker dtp_AddDobSelector;
        private System.Windows.Forms.DateTimePicker dtp_SearchDobSelector;
    }
}