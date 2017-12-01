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

namespace MedClerk.Views
{
    public partial class PatientManagementView : Form
    {
        public PatientManagementView()
        {
            InitializeComponent();
            dtp_AddDobSelector.Value = DateTime.Today;
            dtp_SearchDobSelector.Value = DateTime.Today;
        }

        private void btn_OpenMenu_Click(object sender, EventArgs e)
        {
            PatientController.LoadMenu(this);
        }

        private void btn_ViewPatientProfile_Click(object sender, EventArgs e)
        {
            var id = dGrid_SearchPatientResults.SelectedCells[0].Value.ToString();
            var name = dGrid_SearchPatientResults.SelectedCells[1].Value.ToString();
            var dob = dGrid_SearchPatientResults.SelectedCells[2].Value.ToString();
            var address = dGrid_SearchPatientResults.SelectedCells[3].Value.ToString();
            PatientController.LoadPatientProfile(this, id, name, dob, address);
        }

        private void btn_SearchPatients_Click(object sender, EventArgs e)
        {
            const int DATE_TODAY = 0;

            var id = txtbx_SearchIdField.Text;
            var name = txtbx_SearchNameField.Text;
            var dob = dtp_SearchDobSelector.Value;
            var address = txtbx_SearchAddressField.Text;
            var dateMatch = dob.CompareTo(DateTime.Today);

            if (!String.IsNullOrWhiteSpace(id))
            {
                int tmp;
                if (int.TryParse(id, out tmp))
                {
                    var res = PatientController.FindPatient(tmp);

                    if (res.Rows.Count > 0) { dGrid_SearchPatientResults.DataSource = res; }
                    else
                    {
                        MessageBox.Show("No records found matching that criteria.",
                                "No data found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The ID provided was invalid. Ensure you enter a number (Eg. 101)",
                            "Incorrect input format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(address))
            {
                var res = PatientController.FindPatient(name, address);

                if (res.Rows.Count > 0) { dGrid_SearchPatientResults.DataSource = res; }  
                else
                {
                    MessageBox.Show("No records found matching that criteria.",
                            "No data found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (!String.IsNullOrWhiteSpace(name) && dateMatch != DATE_TODAY)
            {
                var res = PatientController.FindPatient(name, dob);

                if (res.Rows.Count > 0) { dGrid_SearchPatientResults.DataSource = res; }
                else
                {
                    MessageBox.Show("No records found matching that criteria.",
                            "No data found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            dtp_SearchDobSelector.Value = DateTime.Today;
        }

    }
}
