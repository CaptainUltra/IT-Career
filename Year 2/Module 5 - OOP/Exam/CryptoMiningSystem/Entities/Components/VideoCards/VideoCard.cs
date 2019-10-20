namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    using System;
    using Contracts;
    public abstract class VideoCard : Component, IVideoCard
    {
        private int ram;

        protected VideoCard(string model, int generation, int ram, decimal price)
            : base(model, price, generation)
        {
            this.Ram = ram;
        }

        public virtual decimal MinedMoneyPerHour => this.Ram * this.Generation / 10;

        public virtual int Ram
        {
            get => this.ram;
            protected set
            {
                if (value <= 0 || value > 32)
                {
                    throw new ArgumentException($"{this.GetType().Name} ram cannot be less or equal to 0 and more than 32!");
                }
                this.ram = value;
            }
        }
        public override int LifeWorkingHours => this.Ram * this.Generation * 10;
    }
}