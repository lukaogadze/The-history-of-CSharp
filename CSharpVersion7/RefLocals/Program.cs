int no1 = 1;
ref int no2 = ref no1;
no2 = 2;
Console.WriteLine($"local variable {nameof(no1)} after the change: {no1}");
Console.WriteLine("Press any key to Exit.");
Console.ReadLine();