namespace GrandPrix.Entities.Tyres
{
    using System;
    public class UltraoftTyre : Tyre
    {
        public UltraoftTyre(double hardness, double grip) : base("Ultrasoft", hardness)
        {
            this.Grip = grip;
        }
        public override void CompleteLap()
        {
            base.CompleteLap();
            this.Degradation -= this.Grip;
        }
        public override double Degradation
        {
            get => base.Degradation;
            protected set
            {
                if (value < 30)
                {
                    throw new Exception(ErrorMessages.BlownTyre);
                }
                base.Degradation = value;
            }
        }
        public double Grip { get; }
    }
}