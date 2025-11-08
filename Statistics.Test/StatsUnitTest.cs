using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{98.6, 98.2, 97.8, 102.2});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 99.2) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 102.2) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 97.8) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{});
            Assert.True(Double.IsNaN(computedStats.average));
            Assert.True(Double.IsNaN(computedStats.max));
            Assert.True(Double.IsNaN(computedStats.min));
        }
    }
}
