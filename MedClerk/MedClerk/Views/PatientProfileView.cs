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
using MedClerk.Views;

namespace MedClerk.Views
{
    public partial class PatientProfileView : Form
    {
        public PatientProfileView(string id, string name, string dob, string address)
        {
            InitializeComponent();
            lbl_patientId.Text = id;
            lbl_patientName.Text = name;
            lbl_patientDob.Text = dob;
            lbl_patientAddress.Text = address;
            //fillPrescription();
        }

        private void PatientProfileView_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PatientController.BackToPatientManagement(this);
        }

        /*private void fillPrescription()
        {
            dgv_patientPrescriptions.DataSource = PatientModel.getPrescription();
        }

        private void fillTests()
         {
             //dvg_Tests.DataSource = 
         }*/

    }
}
