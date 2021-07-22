namespace Statistics
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent { get; set; }
        public void RaiseAlert()
        {
            emailSent = true;
        }
    }
}