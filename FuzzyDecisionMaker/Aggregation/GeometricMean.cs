using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker.Aggregation
{
    public class GeometricMean : IAggregation
    {
        public double Call(IEnumerable<double> arr)
        {
            int n = arr.Count();
            return Math.Pow(arr.Aggregate((a, b) => a * b), 1.0 / n);
        }
    }
}
