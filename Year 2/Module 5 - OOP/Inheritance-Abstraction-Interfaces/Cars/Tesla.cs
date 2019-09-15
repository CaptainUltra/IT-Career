namespace Cars
{
    public class Tesla : Car, IElectricCar
    {
        private Battery battery;
        private bool isInMotion = false;
        public Battery Battery { get => battery; private set => battery = value; }
        public Tesla(string model, string colour)
        {
            this.Colour = colour;
            this.Model = model;
            this.Battery = new Battery();
        }
        public override string Stop()
        {
            this.isInMotion = false;
            return "Tesla stopped!";
        }
        public override string Start()
        {
            this.isInMotion = true;
            return "Tesla started!";
        }
        public override string ToString()
        {
            return $"My {this.Colour} Tesla {this.Model} {(isInMotion ? "is in motion." : "is stopped.") }";
        }

    }
}