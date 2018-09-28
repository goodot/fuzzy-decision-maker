using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker.Common
{
    public class NameValuePair
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public NameValuePair(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
