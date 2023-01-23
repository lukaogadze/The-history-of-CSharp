// See https://aka.ms/new-console-template for more information

var sample = new UnManagedWrapper<MyStruct>();

Console.WriteLine("Hello, World!");

struct MyStruct
{
    
}

class UnManagedWrapper<T> where T : unmanaged
{ }

