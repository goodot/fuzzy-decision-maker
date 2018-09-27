using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker.Aggregation
{
    public class HarmonicMean : IAggregation
    {
        public double Call(IEnumerable<double> arr)
        {
            double n = arr.Count();
            return n / arr.Aggregate((a, b) => 1.0 / a + 1.0 / b);
        }
    }
}
