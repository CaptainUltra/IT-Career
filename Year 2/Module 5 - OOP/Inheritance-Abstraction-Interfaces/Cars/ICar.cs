namespace Cars
{
    public interface ICar
    {
        string Model { get; set; }
        string Colour { get; set; }
        string Start();
        string Stop();
    }
}