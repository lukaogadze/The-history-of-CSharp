// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public record Person
{
    public sealed override string ToString()
    {
        return base.ToString();
    }
}