namespace CryptoMiningSystem.Entities.Components.Processors
{
    using System;
    public class LowPerformanceProcessor : Processor
    {
        private const int mineMultiplier = 2;
        private string type;
        public LowPerformanceProcessor(string model,int generation, decimal price) 
            : base(model,generation, price, mineMultiplier)
        {
            this.Type = "LowPerformance";
        }
        public override int Generation
        {
            get => base.Generation;
            protected set
            {
                if (value >= 9)
                {
                    string message = "LowPerformanceProcessor generation cannot be more than 9!";
                    throw new ArgumentException(message);
                }
                base.Generation = value;
            }
        }


        public string Type { get => type; set => type = value; }
    }
}