
namespace CryptoMiningSystem.Entities.Components
{
    using System;
    using Contracts;
    public abstract class Component : IComponent
    {
        private string model;
        private decimal price;
        private int generation;

        protected Component(string model, decimal price, int generation)
        {
            this.Model = model;
            this.Price = price;
            this.Generation = generation;
        }

        public virtual int LifeWorkingHours { get; set; }

        public string Model
        {
            get => model;
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }
                this.model = value;
            }
        }
        public decimal Price
        {
            get => price;
            private set
            {
                if (value <= 0 || value > 10000)
                {
                    throw new ArgumentException("Price cannot be less or equal to 0 and more than 10000!");
                }
                this.price = value;
            }
        }

        public virtual int Generation
        {
            get => generation;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Generation cannot be 0 or negative!");
                }
                this.generation = value;
            }
        }
    }
}