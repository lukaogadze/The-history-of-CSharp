using System;

public class Person
{
    public Person(string firstName, string lastName)
    {
        fname = firstName;
        lname = lastName;
    }

    private string fname;
    private string lname;

    public override string ToString() => $"{fname} {lname}".Trim();
    public void DisplayName() => Console.WriteLine(ToString());
}

class Example
{
    static void Main()
    {
        Person p = new Person("Mandy", "Dejesus");
        Console.WriteLine(p);
        p.DisplayName();
    }
}

public class Location
{
    private string locationName;

    public Location(string name)
    {
        locationName = name;
    }

    public string Name => locationName;
}

public class Location2
{
    private string locationName;

    public Location2(string name) => Name = name;

    public string Name
    {
        get => locationName;
        set => locationName = value;
    }
}

public class Location3
{
    private string locationName;

    public Location3(string name) => Name = name;

    public string Name
    {
        get => locationName;
        set => locationName = value;
    }
}

public class Destroyer
{
    public override string ToString() => GetType().Name;

    ~Destroyer() => Console.WriteLine($"The {ToString()} finalizer is executing.");
}


public class Sports
{
    private string[] types = { "Baseball", "Basketball", "Football",
        "Hockey", "Soccer", "Tennis",
        "Volleyball" };

    public string this[int i]
    {
        get => types[i];
        set => types[i] = value;
    }
}