// See https://aka.ms/new-console-template for more information
Program p = new();
Person luka = new("luka");
Console.WriteLine("Hello, World!");

class Person
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }
}