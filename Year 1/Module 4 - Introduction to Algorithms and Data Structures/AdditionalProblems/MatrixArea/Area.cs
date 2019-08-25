public class Area
{
    private int size;
    private int row;
    private int column;
    public Area(int size, int row, int column)
    {
        this.Size = size;
        this.Row = row;
        this.Column = column;
    }
    public override string ToString()
    {
        return $"({this.Row, this.Column}), size: {this.Size}";
    }

    public int Size { get; set; }

    public int Row { get; set; }

    public int Column { get; set; }
}