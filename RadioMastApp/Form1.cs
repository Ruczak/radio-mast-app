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
        private OutcomeTwoMast _outcome;

        public Form1()
        {
            InitializeComponent();
            _outcome = new OutcomeTwoMast();
            axMap.Projection = tkMapProjection.PROJECTION_GOOGLE_MERCATOR;
            axMap.TileProvider = tkTileProvider.OpenStreetMap;
            axMap.KnownExtents = tkKnownExtents.keUSA;
        }

        private List<Point> GetCirclePoints(double lat, double lon, double radius, int res)
        {
            double radiusLon = radius / (111.319 * Math.Cos(lat * Math.PI / 180));
            double radiusLat = radius / 110.574;

            int pointCount = 4;
            for (int i = 0; i < res; i++)
                pointCount *= 2;

            List <Point> points = new List<Point>(pointCount);

            double angle = 2 * Math.PI / pointCount;

            for (int i = 0; i < pointCount; i++)
            {
                points.Add(new Point
                {
                    x = lon + radiusLon * Math.Cos(angle * i),
                    y = lat + radiusLat * Math.Sin(angle * i)
                });
            }

            return points;
        }

        private void CreateCircleShapefile(double lat, double lon, double radius, int res)
        {
            Shapefile sf = new Shapefile();
            int shapeCount = 0;

            sf.CreateNewWithShapeID("", ShpfileType.SHP_POLYGON);

            Shape shape = new Shape();
            shape.Create(ShpfileType.SHP_POLYGON);

            List<Point> points = GetCirclePoints(lat, lon, radius, res);

            for (int i = 0; i < points.Count; i++)
            {
                double projLon = 0, projLat = 0;

                axMap.DegreesToProj(points[i].x, points[i].y, ref projLon, ref projLat);

                shape.InsertPoint(new Point { x = projLon, y = projLat } , ref i);
            }

            sf.EditInsertShape(shape, ref shapeCount);
            shapeCount++;

            sf.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);

            ColorScheme scheme = new ColorScheme();
            scheme.SetColors2(tkMapColor.Wheat, tkMapColor.DarkRed);

            sf.Categories.ApplyColorScheme(tkColorSchemeType.ctSchemeGraduated, scheme);
            sf.DefaultDrawingOptions.FillTransparency = 128;

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
            sf.DefaultDrawingOptions.SetGradientFill(0xff00008b, 0);
            axMap.AddLayer(sf, true);
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

        private void pointButton_Click(object sender, EventArgs e)
        {
            double lat = double.Parse(latBox.Text);
            double lon = double.Parse(lonBox.Text);

            CreatePointShapefile(lat, lon);
            CreateCircleShapefile(lat, lon, 1, 5);
        }
    }
}
