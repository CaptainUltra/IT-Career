namespace CryptoMiningSystem.Entities.Components.Processors
{
    using System;
    using Contracts;
    public abstract class Processor : Component, IProcessor
    {
        protected Processor(string model,int generation, decimal price, int mineMultiplier)
            : base(model, price, generation)
        {
            this.MineMultiplier = mineMultiplier;
        }
        public override int Generation
        {
            get => base.Generation;
            protected set
            {
                if (value >= 9)
                {
                    string message = $"{this.GetType().Name} generation cannot be more than 9!";
                    throw new ArgumentException(message);
                }
                base.Generation = value;
            }
        }
        public override int LifeWorkingHours => this.Generation * 100;
        public int MineMultiplier { get; }
    }
}