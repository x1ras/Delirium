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
    public partial class Main : Form
    {
        Conscious c = new Conscious();

        public Main()
        {
            InitializeComponent();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                var exit = new Exit();
                exit.Show();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}