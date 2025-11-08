using System;
using System.Collections.Generic;

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
        public Stats CalculateStatistics(List<float> numbers)
        {
            var stats = new Stats();
            if (numbers == null || numbers.Count == 0)
            {
                stats.average = Double.NaN;
                stats.min = Double.NaN;
                stats.max = Double.NaN;
                return stats;
            }
            double sum = 0;
            double min = Double.MaxValue;
            double max = Double.MinValue;
            foreach (var num in numbers)
            {
                sum += num;
                if (num < min) min = num;
                if (num > max) max = num;
            }
            stats.average = sum / numbers.Count;
            stats.min = min;
            stats.max = max;
            return stats;
        }
    }
}
