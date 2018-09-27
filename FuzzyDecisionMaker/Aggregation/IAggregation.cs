using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker.Aggregation
{
    public interface IAggregation
    {
        double Call(IEnumerable<double> arr);
    }
}
