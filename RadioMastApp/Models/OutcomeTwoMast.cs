using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RadioMastApp.Models
{
    public class OutcomeTwoMast : Outcome
    {
        public int MastHeight1 { get; set; }
        public int MastHeight2 { get; set; }
        public int Freq { get; set; }
        public double LineOfSight { get; private set; }
        public double FresnelRadius { get; private set; }

        public override void Calculate()
        {
            double d1 = Math.Sqrt(2 * 4D / 3 * 6371000 * MastHeight1);
            double d2 = Math.Sqrt(2 * 4D / 3 * 6371000 * MastHeight2);
            LineOfSight = d1 + d2;
            FresnelRadius = 17.31 * Math.Sqrt(LineOfSight / (4000000 * Freq));
        }

        public override void SaveToFile(string path)
        { 
            using (StreamWriter sw = new StreamWriter(path))
            {
                string JSONString = JsonConvert.SerializeObject(this);
                sw.Write(JSONString);
                sw.Flush();
                sw.Close();
            }
        }
    }
}
