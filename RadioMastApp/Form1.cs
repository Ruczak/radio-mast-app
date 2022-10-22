﻿using System;
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
        private OutcomeTwoMast _twoMastOutcome;
        private OutcomeOneMast _oneMastOutcome;

        public Form1()
        {
            InitializeComponent();
            _twoMastOutcome = new OutcomeTwoMast();
            _oneMastOutcome = new OutcomeOneMast();
            axMap.Projection = tkMapProjection.PROJECTION_GOOGLE_MERCATOR;
            axMap.TileProvider = tkTileProvider.OpenStreetMap;
            axMap.KnownExtents = tkKnownExtents.keUSA;
        }

        private void CreatePolygon(List<Point> points)
        {
            Shapefile sf = new Shapefile();
            int shapeCount = 0;

            sf.CreateNewWithShapeID("", ShpfileType.SHP_POLYGON);

            Shape shape = new Shape();
            shape.Create(ShpfileType.SHP_POLYGON);

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

        private void CreatePoint(double x, double y)
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
            _twoMastOutcome.Freq = int.Parse(freqBox.Text);
            _twoMastOutcome.MastHeight1 = mastBar1.Value;
            _twoMastOutcome.MastHeight2 = mastBar2.Value;

            _twoMastOutcome.Calculate();

            outcomeLabel.Text = $"Line of sight: {Math.Round(_twoMastOutcome.LineOfSight, 4)} m\nFresnel radius: {Math.Round(_twoMastOutcome.FresnelRadius, 4)} m";
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
                    _twoMastOutcome.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            double lat = double.Parse(latBox.Text);
            double lon = double.Parse(lonBox.Text);
            double height = double.Parse(heightBox.Text);

            _oneMastOutcome.Lat = lat;
            _oneMastOutcome.Lon = lon;
            _oneMastOutcome.MastHeight = height;
            _oneMastOutcome.Calculate();

            CreatePoint(lat, lon);
            CreatePolygon(_oneMastOutcome.CirclePoints);
        }
    }
}
