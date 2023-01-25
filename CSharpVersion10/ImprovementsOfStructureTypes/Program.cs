// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public struct Maze
{
    // Parameterless constructor with property initialization 
    public Maze()
    {
        Size = 10;
    }
    
    // Initialization of the property at its declaration
    public int Size { get; set; } = 10;
}