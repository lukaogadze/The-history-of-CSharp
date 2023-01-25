// See https://aka.ms/new-console-template for more information

var p = new Program();

if (p is not null)
{
    
}

Console.WriteLine("Hello, World!");

bool IsLetter(char c) =>
    c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
    
static bool IsLetterOrSeparator(char c) =>
    c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';

    