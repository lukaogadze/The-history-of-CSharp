// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Person
{
    private int Id { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; }
    public Person()
    { }
    public Person(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public virtual Person GetPerson()
    {
        return new Person();
    }
}

public class Employee : Person
{
    private string Department { get; set; }
    public Employee()
    { }
    public Employee(int id, string firstName, string lastName,
        string department) : base(id, firstName, lastName)
    {
        Department = department;
    }
    
    // NOICE!
    public override Employee GetPerson()
    {
        return new Employee();
    }
}