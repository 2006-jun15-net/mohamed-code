using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    public class playerStats
    {
        public double FreeThrowPercentage { get; set; }

        public string Name { get; set; }

        public double PointsPerGame { get; set; }

        public Dictionary<int, double> ArcLocations { get; set; }
    }
}
