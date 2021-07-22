using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            var stats = new Stats();
            
            if(numbers.Count == 0)
            {
                return stats;
            }
            
            stats.average = numbers.Sum() / numbers.Count;
            stats.max = numbers.Max();
            stats.min = numbers.Min();            

            return stats;            
        }
    }
}
