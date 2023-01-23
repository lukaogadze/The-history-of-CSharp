// See https://aka.ms/new-console-template for more information
await foreach (var number in GenerateSequence())
{
    Console.WriteLine(number);
}

Console.WriteLine("Hello, World!");

async IAsyncEnumerable<int> GenerateSequence()
{
    for (int i = 0; i < 20; i++)
    {
        await Task.Delay(100);
        yield return i;
    }
}