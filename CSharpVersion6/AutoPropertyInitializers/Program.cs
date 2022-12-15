namespace AutoPropertyInitializers;

class Sample
{
    public int Count { get; set; } = 2;

    public Sample()
    {
        Console.WriteLine(Count);
    }
}

internal class Program
{
    public static void Main()
    {
        Console.WriteLine(new Sample());
    }
}