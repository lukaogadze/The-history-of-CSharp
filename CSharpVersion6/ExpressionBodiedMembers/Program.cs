namespace ExpressionBodiedMembers;

internal class Program
{
    static void DoSomething() => Console.WriteLine("Like What");
    public static string Name => nameof(Name);
    
    public static void Main(string[] args)
    {
        DoSomething();
    }
}