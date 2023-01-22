// See https://aka.ms/new-console-template for more information

unsafe
{
    Console.WriteLine("Hello, World!");

    var myData = new MyData(39);
    fixed (int* ptr = myData)
    {
        Console.WriteLine(*ptr); 
    }
    
    int[] PascalsTriangle = {
        1,
        1,  1,
        1,  2,  1,
        1,  3,  3,  1,
        1,  4,  6,  4,  1,
        1,  5,  10, 10, 5,  1
    };

    Span<int> RowFive = new Span<int>(PascalsTriangle, 10, 5);

    fixed (int* ptrToRow = RowFive)
    {
        var sum = 0;
        for (int i = 0; i < RowFive.Length; i++)
        {
            sum += *(ptrToRow + i);
        }
        Console.WriteLine(sum);
    }
}

static partial class Program
{
    static MyStructure numbers = new MyStructure();
    static MyStructure cubes = new MyStructure();
    
    static void DoSomething()
    {


    }

    public static unsafe void PrintArrayWithoutPinning()
    {
        for (int i = 0; i < 10; i++)
        {
            numbers.myFixedField[i] = i;
            cubes.myFixedField[i] = i * i * i;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numbers.myFixedField[i] + " cube " + cubes.myFixedField[i]);
        }
    }
}

unsafe struct MyStructure
{
    public fixed int myFixedField[10];
}



public class MyData
{
    private readonly int _value;

    public MyData(int value)
    {
        _value = value;
    }

    public ref readonly int GetPinnableReference()
    {
        return ref _value;
    }        
}