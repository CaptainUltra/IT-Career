using Data.Enumeration;

namespace Data.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public EngineEnum Engine { get; set; }
    }
}
