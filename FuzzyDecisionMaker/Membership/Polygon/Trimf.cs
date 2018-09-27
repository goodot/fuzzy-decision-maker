using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker.Membership.Polygon
{
    public class Trimf: IMembership
    {
        private readonly double a, b, c;
        public Trimf(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Call(double x)
        {
            if (x >= a && x <= b)
                return (x - a) / (b - a);
            else if (x > b && x <= c)
                return (b - x) / (c - b) + 1;
            return 0;
        }
    }
}
