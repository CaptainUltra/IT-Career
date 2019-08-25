namespace TrainTask
{
    public class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int number, string name, string type, int cars)
        {
            this.Number = number;
            this.Name = name;
            this.Type = type;
            this.Cars = cars;
        }

        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Cars { get => cars; set => cars = value; }

        public override string ToString()
        {
            return $"{Number} {Name} {Type} {Cars}";
        }
    }
}