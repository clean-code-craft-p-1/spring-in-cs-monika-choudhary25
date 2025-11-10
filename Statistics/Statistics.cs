using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Stats
    {
        public double average { get; set; }
        public double min { get; set; }
        public double max { get; set; }
    }

    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> temperaturesFahrenheit)
        {
            var stats = new Stats();
            if (temperaturesFahrenheit == null || temperaturesFahrenheit.Count == 0)
            {
                stats.average = Double.NaN;
                stats.min = Double.NaN;
                stats.max = Double.NaN;
                return stats;
            }
            stats.average = temperaturesFahrenheit.Average();
            stats.min = temperaturesFahrenheit.Min();
            stats.max = temperaturesFahrenheit.Max();
            return stats;
        }
    }
}
