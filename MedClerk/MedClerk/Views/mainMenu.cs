using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedClerk.Views;
using MedClerk.Controllers;

namespace MedClerk.Views
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to logout?", "Confirm Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                LoginController.Logout(this);
            }
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            Controllers.StaffController.LoadStaff(this);
        }

        private void appBtn_Click(object sender, EventArgs e)
        {
            Controllers.AppointmentController.LoadAppointment(this);
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            PatientController.LoadPatientManagement(this);
        }
    }
}
