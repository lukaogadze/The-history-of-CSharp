ref int GetFirstOddNumber(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 1)
        {
            return ref numbers[i]; //returning as reference  
        }
    }
    throw new Exception("odd number not found");
}


int[] x = { 2, 4, 62, 54, 33, 55, 66, 71, 92 };
ref int oddNum = ref GetFirstOddNumber(x); //storing as reference  
Console.WriteLine($"\t\t{oddNum}");
oddNum = 350000000;
foreach (var t in x)
{
    Console.Write($"{t}\t");
}
Console.WriteLine();