namespace Statistics
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows { get; set; }
        public void RaiseAlert()
        {
            ledGlows = true;
        }
    }
}