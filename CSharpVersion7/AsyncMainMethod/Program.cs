namespace AsyncMainMethod;

class Program
{
    public static async Task Main()
    {
        await Task.Delay(100);
        Console.WriteLine("Hi");
    }
}