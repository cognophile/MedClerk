using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedClerk.Controllers;
using MedClerk.Models;

namespace MedClerk.Views
{
    public partial class AppointmentManagementView : Form
    {
        public AppointmentManagementView()
        {
            InitializeComponent();
            fillPatients();
            fillStaff();
            fillTimes();
        }
        private void menuBtn_Click(object sender, EventArgs e)
        {
            Controllers.AppointmentController.LoadMainMenu(this);
        }
        private DateTime getSelectedDate()
        {
            return appointmentDatePicker.Value;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var date = appointmentDatePicker.Value;
            var staffMembers = AppointmentController.ProduceAppointments(date);
            appListBox.DataSource = staffMembers;
        }
        private void fillPatients()
        {
            patientIDCB.DataSource = AppointmentController.ProducePatients();
        }
        private void patientIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillStaff()
        {
            staffIDCB.DataSource = AppointmentController.ProduceStaff();
        }
        private void fillTimes()
        {
            timeCB.DataSource = AppointmentController.ProduceTime();
        }
    }
}
