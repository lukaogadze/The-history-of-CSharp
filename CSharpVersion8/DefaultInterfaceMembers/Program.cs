// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var myClass = new MyClass() as IMyInterface;


interface IMyInterface
{
    static IMyInterface()
    {
        MyValue = 23;
    }
    
    const int Const = 5;
    private static readonly int MyValue;
    
    static int operator +(IMyInterface a) => 88;
    static int operator -(IMyInterface a) => 21;

    public static int operator +(IMyInterface a, IMyInterface b) => 212;
    public static int operator -(IMyInterface a, IMyInterface b) => 212;
    
    class Nested
    {
        public Nested() { }
    }
}

class MyClass : IMyInterface
{
    private static readonly int Sample = 23;
    public int GetAge()
    {
        var sz = new IMyInterface.Nested();
        return 33;
    }

    public void SetAge(int age)
    {
        
    }
}