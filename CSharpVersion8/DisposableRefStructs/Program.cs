// See https://aka.ms/new-console-template for more information

using var book = new Book();

Console.WriteLine("Hello, World!");


ref struct Book
{
    public void Dispose()
    {
    }
}