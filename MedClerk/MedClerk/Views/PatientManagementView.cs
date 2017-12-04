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
            if (dGrid_SearchPatientResults.SelectedRows.Count > 0)
            {
                var id = dGrid_SearchPatientResults.SelectedCells[0].Value.ToString();
                var name = dGrid_SearchPatientResults.SelectedCells[1].Value.ToString();
                var dob = dGrid_SearchPatientResults.SelectedCells[2].Value.ToString();
                var address = dGrid_SearchPatientResults.SelectedCells[3].Value.ToString();
                var oTiD = Convert.ToInt32(id);
                var oPiD = Convert.ToInt32(id);
                PatientController.obtainTests(oTiD);
                PatientController.obtainPrescription(oPiD);
                PatientController.LoadPatientProfile(this, id, name, dob, address);
            }
            else
            {
                // Inform the user the search criteria may be invalid
                MessageBox.Show("Please select a patient record to view the profile of. \n\nHint: Click the '>' arrow on the left.",
                        "Incorrect input format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_SearchPatients_Click(object sender, EventArgs e)
        {
            const int DATE_TODAY = 0;

            var id = txtbx_SearchIdField.Text;
            var name = txtbx_SearchNameField.Text.ToLower();
            var dob = dtp_SearchDobSelector.Value;
            var address = txtbx_SearchAddressField.Text.ToLower();
            var dateMatch = dob.CompareTo(DateTime.Today);

            // Protect against no data entered at all
            if (String.IsNullOrEmpty(id) && String.IsNullOrEmpty(name) && dateMatch == DATE_TODAY && String.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter an ID, Name and Address, or Name and Date of Birth to search by.", "Error!",
                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // If the ID field is populated, only search with that
            if (!String.IsNullOrWhiteSpace(id))
            {
                if (int.TryParse(id, out int tmp))
                {
                    var res = PatientController.FindPatient(tmp);

                    // Check data came back
                    if (res.Rows.Count > 0) { dGrid_SearchPatientResults.DataSource = res; return; }
                    else
                    {
                        MessageBox.Show("No records found matching that criteria.",
                                "No data found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    // Inform the user the search criteria may be invalid
                    MessageBox.Show("The ID provided was invalid. Ensure you enter a number (Eg. 101)",
                            "Incorrect input format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // If the ID isn't populated, but both name and address are
            if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(address))
            {
                var res = PatientController.FindPatient(name, address);

                if (res.Rows.Count > 0) { dGrid_SearchPatientResults.DataSource = res; return; }
                else
                {
                    MessageBox.Show("No records found matching that criteria.",
                            "No data found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            // If either the ID or name and address aren't populated, attempt to search by name and date (if the date has changed)
            if (!String.IsNullOrWhiteSpace(name) && dateMatch != DATE_TODAY)
            {
                var res = PatientController.FindPatient(name, dob);

                if (res.Rows.Count > 0) { dGrid_SearchPatientResults.DataSource = res;  return; }
                else
                {
                    MessageBox.Show("No records found matching that criteria.",
                            "No data found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            dtp_SearchDobSelector.Value = DateTime.Today;
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            if (txtbx_AddNameField == null || txtbx_AddAddressField == null || dtp_AddDobSelector == null)
            {
                MessageBox.Show("Error!", "Please Fill all Required Fields Before Adding Patient",
                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                var dob = dtp_AddDobSelector.Value;
                var name = txtbx_AddNameField.Text;
                var address = txtbx_AddAddressField.Text;

                var allAppointments = PatientController.AddPatient(name, address, dob);

                if (allAppointments == true)
                {
                    MessageBox.Show("Success!", "Patient added.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Error!", "Patient couldn't be added.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
