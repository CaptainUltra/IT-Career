namespace CryptoMiningSystem.Entities
{
    using System;
    using Contracts;
    using CryptoMiningSystem.Entities.Components.Processors;
    using CryptoMiningSystem.Entities.Components.VideoCards;

    public class Computer : IComputer
    {
        private int ram;

        public Computer( Processor processor,VideoCard videoCard,int ram)
        {
            this.Ram = ram;
            this.Processor = processor;
            this.VideoCard = videoCard;
        }

        public Processor Processor { get; }

        public VideoCard VideoCard { get; }

        public int Ram
        {
            get => this.ram;
            private set
            {
                if(value <= 0 || value > 32)
                {
                    throw new ArgumentException("PC Ram cannot be less or equal to 0 and more than 32!");
                }
                this.ram = value;
            }
        }

        public decimal MinedAmountPerHour => this.VideoCard.MinedMoneyPerHour * this.Processor.MineMultiplier;
    }
}