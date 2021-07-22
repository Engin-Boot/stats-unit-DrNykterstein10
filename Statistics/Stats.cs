using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public double average { get; set; }
        public double max { get; set; }
        public double min { get; set; }

        public Stats()
        {
            average = Double.NaN;
            max = Double.NaN;
            min = Double.NaN;
        }
    }





}