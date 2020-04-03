namespace ConsoleMVC.Models
{
    public class Tip
    {
        private double amount;
        private double percent;
        public Tip(double amount, double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }
        public Tip() : this(0, 0) { }
        public double CalculateTip()
        {
            return this.Amount * this.Percent;
        }
        public double CalculateTotal()
        {
            return this.Amount + this.CalculateTip();
        }
        public double Amount
        {
            get { return this.amount; }
            private set { this.amount = value; }
        }
        public double Percent
        {
            get { return this.percent; }
            private set
            {
                if (value > 1)
                {
                    this.percent = value / 100.0;
                }
                else
                {
                    this.percent = value;
                }
            }
        }
    }
}