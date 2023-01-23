// See https://aka.ms/new-console-template for more information

string notNull = "Hello";
string? nullable = default;
notNull = nullable; // null forgiveness

Console.WriteLine("Hello, World!");