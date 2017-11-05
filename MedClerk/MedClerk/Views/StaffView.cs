using System;
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
            RegisterListBox.Items.Clear();
            if(RegisterDatePicker.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                RegisterListBox.Items.Add("Practice is closed on Saturdays.");
                return;
            }
            if(RegisterDatePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                RegisterListBox.Items.Add("Practice is closed on Sundays.");
                return;
            }
            else
            {

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
