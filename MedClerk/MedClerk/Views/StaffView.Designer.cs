namespace MedClerk.Views
{
    partial class StaffView
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
            this.lbl_StaffRegAndTblTitle = new System.Windows.Forms.Label();
            this.lbl_StaffUserInstructions = new System.Windows.Forms.Label();
            this.RegisterListBox = new System.Windows.Forms.ListBox();
            this.TimetableListBox = new System.Windows.Forms.ListBox();
            this.ViewRegisterButton = new System.Windows.Forms.Button();
            this.ViewTimetableButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.RegisterDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_StaffRegAndTblTitle
            // 
            this.lbl_StaffRegAndTblTitle.AutoSize = true;
            this.lbl_StaffRegAndTblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StaffRegAndTblTitle.Location = new System.Drawing.Point(24, 17);
            this.lbl_StaffRegAndTblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_StaffRegAndTblTitle.Name = "lbl_StaffRegAndTblTitle";
            this.lbl_StaffRegAndTblTitle.Size = new System.Drawing.Size(365, 30);
            this.lbl_StaffRegAndTblTitle.TabIndex = 6;
            this.lbl_StaffRegAndTblTitle.Text = "Staff Register and Timetable";
            // 
            // lbl_StaffUserInstructions
            // 
            this.lbl_StaffUserInstructions.AutoSize = true;
            this.lbl_StaffUserInstructions.Location = new System.Drawing.Point(24, 63);
            this.lbl_StaffUserInstructions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_StaffUserInstructions.Name = "lbl_StaffUserInstructions";
            this.lbl_StaffUserInstructions.Size = new System.Drawing.Size(1331, 25);
            this.lbl_StaffUserInstructions.TabIndex = 7;
            this.lbl_StaffUserInstructions.Text = "Select a date to view the staff register for. To view a staff members timetable, " +
    "highlight them in the register and click the \'Timetable\' button.";
            // 
            // RegisterListBox
            // 
            this.RegisterListBox.FormattingEnabled = true;
            this.RegisterListBox.ItemHeight = 25;
            this.RegisterListBox.Location = new System.Drawing.Point(619, 106);
            this.RegisterListBox.Margin = new System.Windows.Forms.Padding(6);
            this.RegisterListBox.MultiColumn = true;
            this.RegisterListBox.Name = "RegisterListBox";
            this.RegisterListBox.Size = new System.Drawing.Size(362, 729);
            this.RegisterListBox.TabIndex = 2;
            this.RegisterListBox.SelectedIndexChanged += new System.EventHandler(this.RegisterListBox_SelectedIndexChanged);
            // 
            // TimetableListBox
            // 
            this.TimetableListBox.FormattingEnabled = true;
            this.TimetableListBox.ItemHeight = 25;
            this.TimetableListBox.Location = new System.Drawing.Point(993, 106);
            this.TimetableListBox.Margin = new System.Windows.Forms.Padding(6);
            this.TimetableListBox.MultiColumn = true;
            this.TimetableListBox.Name = "TimetableListBox";
            this.TimetableListBox.Size = new System.Drawing.Size(362, 729);
            this.TimetableListBox.TabIndex = 4;
            // 
            // ViewRegisterButton
            // 
            this.ViewRegisterButton.Location = new System.Drawing.Point(715, 862);
            this.ViewRegisterButton.Margin = new System.Windows.Forms.Padding(6);
            this.ViewRegisterButton.Name = "ViewRegisterButton";
            this.ViewRegisterButton.Size = new System.Drawing.Size(188, 44);
            this.ViewRegisterButton.TabIndex = 1;
            this.ViewRegisterButton.Text = "View Register";
            this.ViewRegisterButton.UseVisualStyleBackColor = true;
            this.ViewRegisterButton.Click += new System.EventHandler(this.ViewRegisterButton_Click);
            // 
            // ViewTimetableButton
            // 
            this.ViewTimetableButton.Location = new System.Drawing.Point(1164, 862);
            this.ViewTimetableButton.Margin = new System.Windows.Forms.Padding(6);
            this.ViewTimetableButton.Name = "ViewTimetableButton";
            this.ViewTimetableButton.Size = new System.Drawing.Size(188, 44);
            this.ViewTimetableButton.TabIndex = 3;
            this.ViewTimetableButton.Text = "View Timetable";
            this.ViewTimetableButton.UseVisualStyleBackColor = true;
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(24, 862);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(6);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(188, 44);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // RegisterDatePicker
            // 
            this.RegisterDatePicker.Location = new System.Drawing.Point(29, 150);
            this.RegisterDatePicker.Name = "RegisterDatePicker";
            this.RegisterDatePicker.Size = new System.Drawing.Size(570, 31);
            this.RegisterDatePicker.TabIndex = 8;
            this.RegisterDatePicker.ValueChanged += new System.EventHandler(this.RegisterDatePicker_ValueChanged);
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 929);
            this.Controls.Add(this.RegisterDatePicker);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.ViewTimetableButton);
            this.Controls.Add(this.ViewRegisterButton);
            this.Controls.Add(this.TimetableListBox);
            this.Controls.Add(this.RegisterListBox);
            this.Controls.Add(this.lbl_StaffUserInstructions);
            this.Controls.Add(this.lbl_StaffRegAndTblTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StaffView";
            this.Text = "StaffView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StaffRegAndTblTitle;
        private System.Windows.Forms.Label lbl_StaffUserInstructions;
        private System.Windows.Forms.ListBox RegisterListBox;
        private System.Windows.Forms.ListBox TimetableListBox;
        private System.Windows.Forms.Button ViewRegisterButton;
        private System.Windows.Forms.Button ViewTimetableButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DateTimePicker RegisterDatePicker;
    }
}