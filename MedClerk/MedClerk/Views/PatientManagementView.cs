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
        }

        private void btn_OpenMenu_Click(object sender, EventArgs e)
        {
            PatientController.LoadMenu(this);
        }
    }
}
