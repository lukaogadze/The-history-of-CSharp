// See https://aka.ms/new-console-template for more information

var ss = new MyClass() { Name = "sadsad"};

Console.WriteLine("Hello, World!");

class MyClass
{
    public required string Name { get; set; }

    public MyClass()
    {
        
    }

    public MyClass(string name)
    {
        Name = name;
    }
}