using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioMastApp
{
    public partial class Form1 : Form
    {
        private Outcome Outcome;

        public Form1()
        {
            InitializeComponent();
            Outcome = new Outcome();
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

        private void calcButton_Click(object sender, EventArgs e)
        {
            Outcome.Freq = int.Parse(freqBox.Text);
            Outcome.MastHeight1 = mastBar1.Value;
            Outcome.MastHeight2 = mastBar2.Value;

            Outcome.Calculate();

            outcomeLabel.Text = $"Line of sight: {Math.Round(Outcome.LineOfSight, 4)} m\nFresnel radius: {Math.Round(Outcome.FresnelRadius, 4)} m";
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json) |*.json|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.Length > 0)
                    Outcome.SaveToFile(saveFileDialog.FileName);
            }
        }
    }
}
