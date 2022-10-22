using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioMastApp.Models
{
    public abstract class Outcome
    {
        public abstract void Calculate();

        public abstract void SaveToFile(string path);
    }
}
