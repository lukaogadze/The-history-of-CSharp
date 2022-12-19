int? maybe = 12;

if (maybe is int number)
{
    Console.WriteLine($"The nullable int 'maybe' has the value {number}");
}
else
{
    Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
}


string? message = "This is not the null string";

if (message is not null)
{
    Console.WriteLine(message);
}

static T MidPoint<T>(IEnumerable<T> sequence)
{
    if (sequence is IList<T> list)
    {
        return list[list.Count / 2];
    }
    else if (sequence is null)
    {
        throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
    }
    else
    {
        int halfLength = sequence.Count() / 2 - 1;
        if (halfLength < 0) halfLength = 0;
        return sequence.Skip(halfLength).First();
    }
}

// static void PerformOperation(string command) =>
//     command switch
//     {
//         "SystemTest" => Console.WriteLine(command),
//         "Start" => Console.WriteLine(command),
//         "Stop" => Console.WriteLine(command),
//         "Reset" => Console.WriteLine(),
//         _ => throw new ArgumentException("Invalid string value for command", nameof(command)),        
//     };


string WaterState(int tempInFahrenheit) =>
    tempInFahrenheit switch
    {
        (> 32) and (< 212) => "liquid",
        < 32 => "solid",
        > 212 => "gas",
        32 => "solid/liquid transition",
        212 => "liquid / gas transition",
    };
    
    
string WaterState2(int tempInFahrenheit) =>
    tempInFahrenheit switch
    {
        < 32 => "solid",
        32 => "solid/liquid transition",
        < 212 => "liquid",
        212 => "liquid / gas transition",
        _ => "gas",
    };    
    
    
// decimal balance = 0m;
// foreach (string[] transaction in ReadRecords())
// {
//     balance += transaction switch
//     {
//         [_, "DEPOSIT", _, var amount]     => decimal.Parse(amount),
//         [_, "WITHDRAWAL", .., var amount] => -decimal.Parse(amount),
//         [_, "INTEREST", var amount]       => decimal.Parse(amount),
//         [_, "FEE", var fee]               => -decimal.Parse(fee),
//         _                                 => throw new InvalidOperationException($"Record {string.Join(", ", transaction)} is not in the expected format!"),
//     };
//     Console.WriteLine($"Record: {string.Join(", ", transaction)}, New balance: {balance:C}");
// }

List<string[]> ReadRecords()
{
    throw new NotImplementedException();
}    