namespace GrandPrix.Entities.Tyres
{
    using System;
    public abstract class Tyre
    {
        private double degradation;
        protected Tyre(string name, double hardness)
        {
            this.Name = name;
            this.Hardness = hardness;
            this.Degradation = 100;
        }
        public virtual void CompleteLap()
        {
            this.Degradation -= this.Hardness;

        }
        public string Name { get; }
        public double Hardness { get; }
        public virtual double Degradation
        {
            get
            {
                return this.degradation;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new Exception(ErrorMessages.BlownTyre);
                }
                this.degradation = value;
            }
        }
    }
}