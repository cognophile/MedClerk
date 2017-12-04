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
            this.lbl_StaffRegAndTblTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_StaffRegAndTblTitle.Name = "lbl_StaffRegAndTblTitle";
            this.lbl_StaffRegAndTblTitle.Size = new System.Drawing.Size(206, 16);
            this.lbl_StaffRegAndTblTitle.TabIndex = 6;
            this.lbl_StaffRegAndTblTitle.Text = "Staff Register and Timetable";
            // 
            // lbl_StaffUserInstructions
            // 
            this.lbl_StaffUserInstructions.AutoSize = true;
            this.lbl_StaffUserInstructions.Location = new System.Drawing.Point(12, 33);
            this.lbl_StaffUserInstructions.Name = "lbl_StaffUserInstructions";
            this.lbl_StaffUserInstructions.Size = new System.Drawing.Size(656, 13);
            this.lbl_StaffUserInstructions.TabIndex = 7;
            this.lbl_StaffUserInstructions.Text = "Select a date to view the staff register for. To view a staff members timetable, " +
    "highlight them in the register and click the \'Timetable\' button.";
            // 
            // RegisterListBox
            // 
            this.RegisterListBox.FormattingEnabled = true;
            this.RegisterListBox.Location = new System.Drawing.Point(310, 55);
            this.RegisterListBox.MultiColumn = true;
            this.RegisterListBox.Name = "RegisterListBox";
            this.RegisterListBox.Size = new System.Drawing.Size(183, 381);
            this.RegisterListBox.TabIndex = 2;
            // 
            // TimetableListBox
            // 
            this.TimetableListBox.FormattingEnabled = true;
            this.TimetableListBox.Location = new System.Drawing.Point(496, 55);
            this.TimetableListBox.MultiColumn = true;
            this.TimetableListBox.Name = "TimetableListBox";
            this.TimetableListBox.Size = new System.Drawing.Size(183, 381);
            this.TimetableListBox.TabIndex = 4;
            // 
            // ViewRegisterButton
            // 
            this.ViewRegisterButton.Location = new System.Drawing.Point(399, 442);
            this.ViewRegisterButton.Name = "ViewRegisterButton";
            this.ViewRegisterButton.Size = new System.Drawing.Size(94, 23);
            this.ViewRegisterButton.TabIndex = 1;
            this.ViewRegisterButton.Text = "View Register";
            this.ViewRegisterButton.UseVisualStyleBackColor = true;
            this.ViewRegisterButton.Click += new System.EventHandler(this.ViewRegisterButton_Click);
            // 
            // ViewTimetableButton
            // 
            this.ViewTimetableButton.Location = new System.Drawing.Point(585, 442);
            this.ViewTimetableButton.Name = "ViewTimetableButton";
            this.ViewTimetableButton.Size = new System.Drawing.Size(94, 23);
            this.ViewTimetableButton.TabIndex = 3;
            this.ViewTimetableButton.Text = "View Timetable";
            this.ViewTimetableButton.UseVisualStyleBackColor = true;
            this.ViewTimetableButton.Click += new System.EventHandler(this.ViewTimetableButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(15, 442);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(94, 23);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // RegisterDatePicker
            // 
            this.RegisterDatePicker.Location = new System.Drawing.Point(15, 68);
            this.RegisterDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegisterDatePicker.Name = "RegisterDatePicker";
            this.RegisterDatePicker.Size = new System.Drawing.Size(255, 20);
            this.RegisterDatePicker.TabIndex = 8;
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 483);
            this.Controls.Add(this.RegisterDatePicker);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.ViewTimetableButton);
            this.Controls.Add(this.ViewRegisterButton);
            this.Controls.Add(this.TimetableListBox);
            this.Controls.Add(this.RegisterListBox);
            this.Controls.Add(this.lbl_StaffUserInstructions);
            this.Controls.Add(this.lbl_StaffRegAndTblTitle);
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