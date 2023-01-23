// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


struct MyStruct
{
    public int X { get; }
    public int Y { get; }
    private int _counter;
    
    public readonly double Z { get; init; }

    public int Counter
    {
        readonly get => _counter;
        set => _counter = value;
    }
    public MyStruct(int x, int y)
    {
        X = x;
        Y = y;
        _counter = 0;
        Z = 0;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}