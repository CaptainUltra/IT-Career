namespace Machine
{
    public class Car : IMachine
    {
        public string MachineType { get; set; }
        public Car()
        {
            this.MachineType = "Car";
        }
        public bool Start()
        {
            System.Console.WriteLine("Car starting...");
            return true;
        }

        public bool Stop()
        {
            System.Console.WriteLine("Car stopping...");
            return true;
        }
    }
}