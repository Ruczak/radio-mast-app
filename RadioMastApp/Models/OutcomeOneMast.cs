using MapWinGIS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioMastApp.Models
{
    public class OutcomeOneMast : Outcome
    {
        public double MastHeight { get; set; }
        public double Lat{ get; set; }
        public double Lon { get; set; }
        public double LineOfSight { get; private set; }
        public List<Point> CirclePoints { get; private set; }

        public override void Calculate()
        {
            LineOfSight = Math.Sqrt(2 * 6371000 * MastHeight);

            double radiusLon = LineOfSight / 1000 / (111.319 * Math.Cos(Lat * Math.PI / 180));
            double radiusLat = LineOfSight / 1000 / 110.574;

            int pointCount = 64; // resolution of the circle

            List<Point> points = new List<Point>(pointCount);

            double angle = 2 * Math.PI / pointCount;

            for (int i = 0; i < pointCount; i++)
            {
                points.Add(new Point
                {
                    x = Lon + radiusLon * Math.Cos(angle * i),
                    y = Lat + radiusLat * Math.Sin(angle * i)
                });
            }

            CirclePoints = points;
        }

        public override void SaveToFile(string path)
        {
            string coords = "";
            for (int i = 0; i < CirclePoints.Count; i++)
            {
                coords += $"[{CirclePoints[i].y}, {CirclePoints[i].x}],\n";
            }
            coords += $"[{CirclePoints[0].y}, {CirclePoints[0].x}]\n";

            string JSONString = @"{
              ""type"": ""FeatureCollection"",
              ""features"": [
                {
                  ""type"": ""Feature"",
                  ""geometry"": {
                    ""type"": ""Point"",
                    ""coordinates"": [" + Lon.ToString() + "," + Lat.ToString() + @"]
                  },
                  ""properties"": {}
                },
                {
                  ""type"": ""Feature"",
                  ""geometry"": {
                    ""type"": ""Polygon"",
                    ""coordinates"": [
                      [ 
                        " + coords + @"]
                    ]
                  },
                  ""properties"": {}
                }
              ]
            }";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(JSONString);
                sw.Flush();
                sw.Close();
            }
        }
    }
}
