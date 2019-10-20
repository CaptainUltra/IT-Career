namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    using System;
    public class MineVideoCard : VideoCard
    {
        private string type;
        public MineVideoCard(string model, int generation, int ram, decimal price)
            : base(model, generation, ram, price)
        {
            this.Type = "Mine";
        }

        public override int Generation
        {
            get => base.Generation;
            protected set
            {
                if (value >= 6)
                {
                    throw new ArgumentException($"{this.GetType().Name} generation cannot be more than 6!");
                }
                base.Generation = value;
            }
        }
        public override decimal MinedMoneyPerHour => base.MinedMoneyPerHour * 8;

        public string Type { get => type; private set => type = value; }
    }
}