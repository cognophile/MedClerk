﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedClerk.Models;
using MedClerk.Controllers;

namespace MedClerk.Views
{
    public partial class StaffView : Form
    {
        public StaffView()
        {
            InitializeComponent();
        }

        private DateTime getSelectedDate()
        {
            return RegisterDatePicker.Value;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Controllers.StaffController.LoadMainMenu(this);
        }

        private void ViewRegisterButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox of previous data for easier reading
            //RegisterListBox.DataSource = null;
            
            if(RegisterDatePicker.Value.DayOfWeek == DayOfWeek.Saturday || RegisterDatePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                //Disables view timetable button because there is no data to show
                ViewTimetableButton.Enabled = false;
                //Displays a message in RegisterListBox
                RegisterListBox.DataSource = null;
                MessageBox.Show("Practice is closed on weekends!", "No data found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            //Enables button due to there is data to present
            ViewTimetableButton.Enabled = true;
                
            var date = getSelectedDate();

            //Collect the data from the database
            var staffMembers = StaffController.ProduceRegister(date);

            if (!staffMembers.Any())
            {
                MessageBox.Show("No staff data was found for this date.", "No data found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                RegisterListBox.DataSource = null;
            }
            else
            {
                RegisterListBox.DataSource = null;
                RegisterListBox.DataSource = staffMembers;
            }
        }
        private void ViewTimetableButton_Click(object sender, EventArgs e)
        {
            var date = getSelectedDate();
            var staffMember = RegisterListBox.GetItemText(RegisterListBox.SelectedItem);

            // Collect the data from the database
            var timetable = StaffController.ProduceTimetable(date, staffMember);
            TimetableListBox.DataSource = null;
            TimetableListBox.DataSource = timetable;
        }
    }
}
