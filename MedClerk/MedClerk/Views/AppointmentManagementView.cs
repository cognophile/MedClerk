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
        private void patientIDCB_Load(object sender, EventArgs e)
        {
            PatientModel patient = new PatientModel();
            DataTable dt = new DataTable();
            dt.Columns.Add("Patient Name", typeof(string));
            patientIDCB.ValueMember = "Patient Name";
            patientIDCB.DataSource = dt;
        }
        private void patientIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string patient = patientIDCB.SelectedValue.ToString();
        }
    }
}
