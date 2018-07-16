using System;
using System.Collections.Generic;

namespace GrowTestApi.Model
{
    public class Policy
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CoverageType> Coverage { get; set; }
        public DateTime StartDay { get; set; }
        public int CoveragePeriod { get; set; }
        public decimal Ammount { get; set; }
        public Risk RiskType { get; set; }
        public Agency Agency { get; set; }
        public Customer Customer { get; set; }

        public Policy() { }
    }
}
