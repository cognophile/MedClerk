﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedClerk.Views
{
    public partial class StaffView : Form
    {
        public StaffView()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Controllers.StaffController.LoadMainMenu(this);
        }
    }
}
