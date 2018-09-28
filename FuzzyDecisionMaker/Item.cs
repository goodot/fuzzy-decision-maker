using FuzzyDecisionMaker.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker
{
    public class Item
    {
        public string Identifier { get; set; }
        public List<NameValuePair> FeatureValues { get; set; } = new List<NameValuePair>();

        public void AddFeatureValue(NameValuePair featureValue)
        {
            FeatureValues.Add(featureValue);
        }


    }
}
