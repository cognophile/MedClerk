using System;
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

        public DateTime getSelectedDate()
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
            
            if(RegisterDatePicker.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                //Disables view timetable button because there is no data to show
                ViewTimetableButton.Enabled = false;
                //Displays a message in RegisterListBox
                RegisterListBox.Items.Add("Practice is closed on Saturdays.");
                RegisterListBox.Items.Clear();
                return;
            }
            if(RegisterDatePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                //Disables view timetable button because there is no data to show
                ViewTimetableButton.Enabled = false;
                //Displays a message in RegisterListBox
                RegisterListBox.Items.Add("Practice is closed on Sundays.");
                RegisterListBox.Items.Clear();
                return;
            }
            else
            {
                //Enables button due to there is data to present
                ViewTimetableButton.Enabled = true;
                //Collect the data from the database
                var staffMembers = StaffController.FindStaff(this);
                RegisterListBox.DataSource = staffMembers;
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
