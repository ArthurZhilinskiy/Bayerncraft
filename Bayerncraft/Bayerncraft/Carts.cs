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
    public partial class Carts : UserControl
    {
        public Carts()
        {
            InitializeComponent();
        }
        public string Name { get; set; }
        public Image Image { get; set; }
        public MainForm MainForm { get; set; }
        public Carts(string name, Image img, MainForm mainForm)
        {
            InitializeComponent();
            Name = name;
            Image = img;
            MainForm = mainForm;                                                                   
        }


    }
}
