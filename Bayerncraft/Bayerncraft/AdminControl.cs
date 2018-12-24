using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bayerncraft
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        private void NewMark_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            NewCarControl newCarControl = new NewCarControl();
            flowLayoutPanel1.Controls.Add(newCarControl);
        }

        private void NewDetail_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            NewPartControl newPartControl = new NewPartControl();
            flowLayoutPanel1.Controls.Add(newPartControl);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            NewAdminkaControl newAdminkaControl = new NewAdminkaControl();
            flowLayoutPanel1.Controls.Add(newAdminkaControl);
        }
    }
}
