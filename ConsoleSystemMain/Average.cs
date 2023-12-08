using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject
{
    class Average
    {
        public double Total { get; set; } = 0.0;
        public int Count { get; set; }

        public double CalAverage()
        {
            return Total = Total / (double)Count;
        }

        public override string ToString()
        {
            return "Result of average " + Count + " numbers: " + CalAverage().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
