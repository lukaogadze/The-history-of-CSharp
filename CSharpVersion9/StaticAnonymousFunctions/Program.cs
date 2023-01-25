// See https://aka.ms/new-console-template for more information

DisplayText(static (x, y) => { Console.WriteLine($"{x} - {y}"); });
void DisplayText(Action<string, string> func)
{
    func("asd", "asdasd");
}


Console.WriteLine("Hello, World!");