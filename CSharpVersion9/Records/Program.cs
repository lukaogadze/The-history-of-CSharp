// See https://aka.ms/new-console-template for more information

var luka = new Person("luka", "asdkjasdkj");
var lika = new Person2()
{
    FirstName = "ASDasd",
    LastName = "asdsadsad"
};

// luka.FirstName = "sda"; error FirstName is init only

Console.WriteLine("Hello, World!");

public record Person(string FirstName, string LastName);

public record Person2
{
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
};