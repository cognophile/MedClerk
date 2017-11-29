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
        public PatientProfileView()
        {
            InitializeComponent();

            //fillTests();
            fillPrescription();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PatientController.BackToPatientManagement(this);
        }

        private void fillPrescription()
        {
            dgv_patientPrescriptions.DataSource = PatientModel.getPrescription();
        }

       /* private void fillTests()
        {
            //dvg_Tests.DataSource = 
        }*/

    }
}
