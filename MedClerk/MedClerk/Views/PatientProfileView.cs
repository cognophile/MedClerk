using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MedClerk.Controllers;
using MedClerk.Models;
using MedClerk.Views;
using System.Diagnostics;

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
        }

        private void PatientProfileView_Load(object sender, EventArgs e)
        {
            this.fillPrescription(Int32.Parse(lbl_patientId.Text));
            this.fillTests(Int32.Parse(lbl_patientId.Text));
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PatientController.BackToPatientManagement(this);
        }

        private void fillPrescription(int fP)
        {
            dgv_patientPrescriptions.DataSource = PatientController.obtainPrescription(fP);
        }

        private void fillTests(int oT)
         {
            dvg_Tests.DataSource = PatientController.obtainTests(oT);
         }

        private void btn_PrintSelectedTest_Click(object sender, EventArgs e)
        {
            // Output test reults to text file
            var path = @"C:\PatientTests\PatientTestResults.txt";
            StreamWriter print = new StreamWriter(path);
            for(int i = 0; i < 1; i++)
            {
                string lines = "";
                for (int j = 0; j < 5; j++)
                {
                    lines += (string.IsNullOrEmpty(lines) ? " " : ", ") + dvg_Tests.Rows[i].Cells[j].Value.ToString();
                }
                print.WriteLine(lines);
            }
            print.Close();
            MessageBox.Show("Test Printed");

            // Print produced text file
            ProcessStartInfo psi = new ProcessStartInfo(path);
            psi.Verb = "PRINT";
            Process.Start(psi);

        }

        private void btn_ExtendSelectedPrescription_Click(object sender, EventArgs e)
        {
            /*dtp_prescriptionEndDate.Value = DateTime.Today;

            var endDate = dtp_prescriptionEndDate.Value;*/
        }
    }
}
