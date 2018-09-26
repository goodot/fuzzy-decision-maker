using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker.Membership
{
    public interface IMembership
    {
        double Call(double x);
    }
}
