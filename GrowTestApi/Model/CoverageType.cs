using System;
namespace GrowTestApi.Model
{
    public class CoverageType
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public long Percentage { get; set; }

        public CoverageType()
        {
        }
    }
}
