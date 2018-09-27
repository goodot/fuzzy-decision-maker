using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker.Aggregation
{
    public class ArithmeticMean : IAggregation
    {
        public double Call(IEnumerable<double> arr)
        {
            return arr.Average();
        }
        
    }
}
