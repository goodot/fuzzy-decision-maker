using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker.Membership.Sigmoid
{
    public class SNonLinear : IMembership
    {
        private readonly double a, b;
        public SNonLinear(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Call(double x)
        {
            return (1.0 / 2) + (1.0 / 2) * Math.Cos(((x - b) * Math.PI) / (b - a));
        }
    }
}
