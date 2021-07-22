using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsAlerter
    {
        private float threshold;
        private IAlerter[] alerters;

        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.threshold =  maxThreshold;
            this.alerters = alerters;
        }

        public void checkAndAlert(List<float> numbers)
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