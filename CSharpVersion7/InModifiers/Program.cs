// See https://aka.ms/new-console-template for more information


void DoWork(in Person person)
{
    // person = new Person("ASdsad") Error
}

Console.WriteLine("Hello, World!");

class Person
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }
}