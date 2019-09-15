namespace Cars
{
    public class Battery
    {
        public int Capacity { get; set; }
        public int Voltage { get; set; }
        public Battery()
        {
            this.Capacity = 2000;
            this.Voltage = 300;
        }
    }
}