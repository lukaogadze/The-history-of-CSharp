// See https://aka.ms/new-console-template for more information

Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
var indx = numbers.IndexOfAny(stackalloc[] { 2, 4, 6 ,8 });
Console.WriteLine(indx);  // output: 1

Console.WriteLine("Hello, World!");