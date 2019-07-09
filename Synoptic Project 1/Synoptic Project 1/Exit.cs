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
    public partial class Exit : Form
    {
        Conscious c = new Conscious();

        public Exit()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            c.Exit();
        }

        private void lbStay1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
