namespace CryptoMiningSystem.Entities.Components.Processors
{
    using System;
    public class HighPerformanceProcessor : Processor
    {
        private const int mineMultiplier = 8;
        private string type;
        public HighPerformanceProcessor(string model,int generation, decimal price) 
            : base(model ,generation, price, mineMultiplier)
        {
            this.Type = "HighPerformance";
        }
        public override int Generation
        {
            get => base.Generation;
            protected set
            {
                if (value >= 9)
                {
                    string message = "HighPerformanceProcessor generation cannot be more than 9!";
                    throw new ArgumentException(message);
                }
                base.Generation = value;
            }
        }

        public string Type { get => type; private set => type = value; }
    }
}