// See https://aka.ms/new-console-template for more information


IEnumerator<string> countryEnumerator = (IEnumerator<string>)new List<string> { "France", "Canada", "Japan" };

// Before C# 9: Error CS1579  foreach statement cannot operate on variables of type 'IEnumerator<string>' 
// because 'IEnumerator<string>' does not contain a public instance or extension definition for 'GetEnumerator'
foreach (var country in countryEnumerator)
{
    Console.WriteLine($"{country} is a beautiful country");
}

Console.WriteLine("Hello, World!");

public static class Extensions
{
    public static IEnumerator<T> GetEnumerator<T>(this IEnumerator<T> enumerator) => enumerator;
}
