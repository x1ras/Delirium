﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synoptic_Project_1
{
    public partial class Delirium : Form
    {
        Conscious c = new Conscious();

        public Delirium()
        {
            InitializeComponent();
            pl1.Show();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            pl2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pl2.Hide();
        }
    }
}