// See https://aka.ms/new-console-template for more information

unsafe
{
    var arr1 = stackalloc int[3];				// currently allowed
    var arr2 = stackalloc int[3] { 1, 2, 3 };
    var arr3 = stackalloc int[] { 1, 2, 3 };
    var arr4 = stackalloc[] { 1, 2, 3 };

    Console.WriteLine("Hello, World!");
}