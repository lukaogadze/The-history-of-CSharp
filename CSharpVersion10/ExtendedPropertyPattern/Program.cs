// See https://aka.ms/new-console-template for more information

Object obj = new object();

if (obj is Developer { Manager: { FirstName: "Thomas" } } developerWithThomasAsManager)
{
    // Use the developerWithThomasAsManager variable here
    Console.WriteLine(developerWithThomasAsManager);
}

Console.WriteLine("Hello, World!");

public class Person
{
    public string? FirstName { get; set; }
    public int YearOfBirth { get; set; }
}
public class Developer : Person
{
    public Manager? Manager { get; set; }
}
public class Manager : Person
{
}