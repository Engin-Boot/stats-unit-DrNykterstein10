using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsAlerter
    {
        private double threshold;
        private IAlerter[] alerters;

        public StatsAlerter(double maxThreshold, IAlerter[] alerters)
        {
            this.threshold =  maxThreshold;
            this.alerters = alerters;
        }

        public void checkAndAlert(List<double> numbers)
        {
            var maxValue = numbers.Max();

            if(maxValue > threshold)
            {
                foreach (var alerter in alerters)
                {
                    alerter.RaiseAlert();
                }
            }
        }
    }
}