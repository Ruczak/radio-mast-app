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
using RadioMastApp.Models;
using AxMapWinGIS;
using MapWinGIS;
using Point = MapWinGIS.Point;
using System.Xml.XPath;

namespace RadioMastApp
{
    public partial class Form1 : Form
    {
        private Outcome _outcome;

        public Form1()
        {
            InitializeComponent();
            _outcome = new Outcome();
            axMap.Projection = tkMapProjection.PROJECTION_GOOGLE_MERCATOR;
            axMap.TileProvider = tkTileProvider.OpenStreetMap;
            axMap.KnownExtents = tkKnownExtents.keUSA;
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
            _outcome.Freq = int.Parse(freqBox.Text);
            _outcome.MastHeight1 = mastBar1.Value;
            _outcome.MastHeight2 = mastBar2.Value;

            _outcome.Calculate();

            outcomeLabel.Text = $"Line of sight: {Math.Round(_outcome.LineOfSight, 4)} m\nFresnel radius: {Math.Round(_outcome.FresnelRadius, 4)} m";
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
                    _outcome.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void CreateCircleShapefile(double x, double y, double radius, int res)
        {
            Shapefile sf = new Shapefile();
            int shapeCount = 0;

            bool result = sf.CreateNewWithShapeID("", ShpfileType.SHP_POLYGON);

            Shape shape = new Shape();
            shape.Create(ShpfileType.SHP_POLYGON);

            for (int i = 0; i < Math.Pow(2, 2 + res); i++)
            {
                double projX = 0, projY = 0;

                axMap.DegreesToProj(
                    y + radius * Math.Cos(i * 2 * Math.PI / Math.Pow(2, 2 + res)),
                    x - radius * Math.Sin(i * 2 * Math.PI / Math.Pow(2, 2 + res)),
                    ref projX, ref projY);
                

                Point point = new Point
                { 
                    x = projX,
                    y = projY
                };

                shape.InsertPoint(point, ref i);
            }

            sf.EditInsertShape(shape, ref shapeCount);
            shapeCount++;

            sf.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);

            ColorScheme scheme = new ColorScheme();
            scheme.SetColors2(tkMapColor.Wheat, tkMapColor.DarkRed);

            sf.Categories.ApplyColorScheme(tkColorSchemeType.ctSchemeGraduated, scheme);
            sf.DefaultDrawingOptions.FillTransparency = 50;
            
            axMap.AddLayer(sf, true);
        }

        private void CreatePointShapefile(double x, double y)
        {
            Shapefile sf = new Shapefile();
            int shapeCount = 0;

            bool result = sf.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            double projX = 0, projY = 0;

            axMap.DegreesToProj(y, x, ref projX, ref projY);

            Point point = new Point
            {
                x = projX,
                y = projY
            };

            Shape shape = new Shape();
            shape.Create(ShpfileType.SHP_POINT);

            int index = 0;

            shape.InsertPoint(point, ref index);
            sf.EditInsertShape(shape, ref shapeCount);
            shapeCount++;

            sf.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
            sf.DefaultDrawingOptions.SetGradientFill(0xff0000ff, 0);
            axMap.AddLayer(sf, true);
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            double x = double.Parse(latBox.Text);
            double y = double.Parse(lonBox.Text);

            CreatePointShapefile(x, y);
            CreateCircleShapefile(x, y, 2, 5);
        }
    }
}
