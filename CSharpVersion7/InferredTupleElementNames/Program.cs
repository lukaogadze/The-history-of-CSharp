static Task<int> FibonacciAsync(int n, CancellationToken token = default)
{
    return Task.FromResult(0);
};

static async Task DoWork(int input)
{
    var tuple = (input, task: FibonacciAsync(input));
    Console.WriteLine($"Fib {tuple.input} = {await tuple.task}");
}

await DoWork(22);