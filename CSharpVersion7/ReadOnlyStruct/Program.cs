// See https://aka.ms/new-console-template for more information

void DoWork(in MyStruct @struct)
{
    // @struct = new MyStruct(23); // ERROR
    
}

Console.WriteLine("Hello, World!");


readonly struct MyStruct
{
    // public int Age { get; set; } ERRor
    public int Age { get; }


    public MyStruct(int age)
    {
        Age = age;
    }
} 

