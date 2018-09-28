using FuzzyDecisionMaker.Aggregation;
using FuzzyDecisionMaker.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyDecisionMaker
{
    public class Analyzer
    {
        public List<Feature> Features { get; set; }
        public List<Item> Items { get; set; }
        public IAggregation AggregationFunction { get; set; }

        public Analyzer(List<Feature> features, List<Item> items, IAggregation aggregation)
        {
            Features = features;
            Items = items;
            AggregationFunction = aggregation;
        }

        public List<Result> Analyze()
        {
            throw new NotImplementedException();
        }
    }
}
