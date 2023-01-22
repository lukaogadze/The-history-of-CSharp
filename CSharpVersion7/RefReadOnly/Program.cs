// See https://aka.ms/new-console-template for more information

ref readonly MyStruct GetStruct(in MyStruct dd)
{
    return ref dd;
}

var s = GetStruct(new MyStruct());


Console.WriteLine("Hello, World!");

struct MyStruct
{
    public int Number { get; }

    public MyStruct(int number)
    {
        Number = number;
    }
}