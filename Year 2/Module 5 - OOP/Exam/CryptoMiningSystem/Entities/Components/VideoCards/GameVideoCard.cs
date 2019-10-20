namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    using System;
    public class GameVideoCard : VideoCard
    {
        private string type;
        public GameVideoCard(string model, int generation, int ram, decimal price)
            : base(model, generation, ram, price)
        {
            this.Type = "Game";
        }
        public override int Generation
        {
            get => base.Generation;
            protected set
            {
                if (value >= 9)
                {
                    throw new ArgumentException($"GameVideoCard generation cannot be more than 9!");
                }
                base.Generation = value;
            }
        }
        public override decimal MinedMoneyPerHour => base.MinedMoneyPerHour * 2;

        public string Type { get => type; private set => type = value; }
    }
}