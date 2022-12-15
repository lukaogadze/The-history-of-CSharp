namespace NullPropagator;

internal class Program
{
    public string Name { get; set; }
    
    static void Main()
    {
        Program program = null;
        Console.WriteLine(program?.Name);
    }
}