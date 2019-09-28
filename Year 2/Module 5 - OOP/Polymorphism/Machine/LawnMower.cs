namespace Machine
{
    public class LawnMower : IMachine
    {
        public string MachineType { get; set; }
        public LawnMower()
        {
            this.MachineType = "LawnMower";
        }
        public bool Start()
        {
            System.Console.WriteLine("Lawnmower starting...");
            return true;
        }

        public bool Stop()
        {
            System.Console.WriteLine("Lawnmower stopping...");
            return true;
        }
    }
}