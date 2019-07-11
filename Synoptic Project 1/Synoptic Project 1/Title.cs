using System;
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            c.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            this.Hide();
        }
    }
}