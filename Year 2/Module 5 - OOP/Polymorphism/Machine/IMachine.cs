namespace Machine
{
    public interface IMachine
    {
        string MachineType {get; set;}
        bool Start();
        bool Stop();
    }
}