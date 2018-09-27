using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker.Membership
{
    public class Threshold: IMembership
    {
        private readonly double threshold;
        public Threshold(double t)
        {
            threshold = t;
        }

        public double Call(double x)
        {
            return x > threshold ? 1 : 0;
        }
    }
}
