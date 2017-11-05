﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedClerk.Views
{
    public partial class StaffView : Form
    {
        public StaffView()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Controllers.StaffController.LoadMainMenu(this);
        }

        private void ViewRegisterButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox of previous data for easier reading
            RegisterListBox.Items.Clear();
            if(RegisterDatePicker.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                //Disables view timetable button because there is no data to show
                ViewTimetableButton.Enabled = false;
                //Displays a message in RegisterListBox
                RegisterListBox.Items.Add("Practice is closed on Saturdays.");
                return;
            }
            if(RegisterDatePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                //Disables view timetable button because there is no data to show
                ViewTimetableButton.Enabled = false;
                //Displays a message in RegisterListBox
                RegisterListBox.Items.Add("Practice is closed on Sundays.");
                return;
            }
            else
            {
                //Enables button due to there is data to present
                ViewTimetableButton.Enabled = true;
                //Collect the data from the database

            }
        }

        private void RegisterDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RegisterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
