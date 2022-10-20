using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioMastApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mastBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            heightLabel1.Text = $"{bar.Value} m";
        }

        private void mastBar2_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            heightLabel2.Text = $"{bar.Value} m";
        }
    }
}
