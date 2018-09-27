using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker
{
    public class Feature<T>
    {
        public T Item { get; set; }
        public double Weight { get; set; } = 1;
    }
}
