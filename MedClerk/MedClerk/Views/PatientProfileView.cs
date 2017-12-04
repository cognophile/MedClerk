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
using System.Drawing.Printing;

namespace MedClerk.Views
{
    public partial class PatientProfileView : Form
    {
        private string path = @"C:\PatientTests\PatientTestResults.txt";

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
            // Output test reults to CSV text file
            StreamWriter print = new StreamWriter(this.path);
            for(int i = 0; i < dvg_Tests.RowCount; i++)
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

            

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(this.printTestResultsFile);
            PrintDialog dialog = new PrintDialog();
            dialog.Document = doc;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
            else
            {
                MessageBox.Show("Print Cancelled");
            }

            doc.Print();
        }

        private void printTestResultsFile(object sender, PrintPageEventArgs ev)
        {
            StreamReader resultsFile = new StreamReader(this.path);
            Font printFont = new Font("Ariel", 10);

            // First print functionality code
            // Print produced text file
            //ProcessStartInfo psi = new ProcessStartInfo(path);
            //psi.Verb = "PRINT";
            //Process.Start(psi);

            // Improved print functionality code
            //  Cite: https://msdn.microsoft.com/en-us/library/system.drawing.printing.printdocument.aspx
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = resultsFile.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void btn_ExtendSelectedPrescription_Click(object sender, EventArgs e)
        {
            //Get selected date
            var newDate = dtp_prescriptionEndDate.Value;

            //dtp_prescriptionEndDate.Value = DateTime.Today;
            //var newEndDate = new DateTime(dtp_prescriptionEndDate.Value);
            //dtp_prescriptionEndDate.Value = Convert.ToDateTime(newEndDate);

            //Obtaining data from data grid view
            var prescriptionId = dgv_patientPrescriptions.SelectedCells[0].Value.ToString();
            var patientId = dgv_patientPrescriptions.SelectedCells[1].Value.ToString();
            var endDate = dgv_patientPrescriptions.SelectedCells[4].Value.ToString();

            //Converting from objects to values
            var prescriptionID = Convert.ToInt32(prescriptionId);
            var patientID = Convert.ToInt32(patientId);

            //Transfer data
            var result = PatientController.extendPrescription(prescriptionID, patientID, newDate);

            if (result)
            {
                MessageBox.Show("The prescription was extended. Click okay to refresh the table.", "Success!",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgv_patientPrescriptions.DataSource = PatientController.obtainPrescription(patientID);
                return;
            }
            else
            {
                MessageBox.Show("Please Fill all Required Fields", "Error!",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
