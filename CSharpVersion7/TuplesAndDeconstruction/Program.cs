(double, int) t1 = (4.5, 3);
Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
// Output:
// Tuple with elements 4.5 and 3.

(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
// Output:
// Sum of 3 elements is 4.5.

(double, int) t = (4.5, 3);
Console.WriteLine(t.ToString());
Console.WriteLine($"Hash code of {t} is {t.GetHashCode()}.");
// Output:
// (4.5, 3)
// Hash code of (4.5, 3) is 718460086.


var t0 =
    (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
        11, 12, 13, 14, 15, 16, 17, 18,
        19, 20, 21, 22, 23, 24, 25, 26);
Console.WriteLine(t0.Item26); // output: 26

var t22 = (Sum: 4.5, Count: 3);
Console.WriteLine($"Sum of {t22.Count} elements is {t22.Sum}.");

(double Sum, int Count) d = (4.5, 3);
Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");


var sum = 4.5;
var count = 3;
var t11 = (sum, count);
Console.WriteLine($"Sum of {t11.count} elements is {t11.sum}.");


var a = 1;
var t123 = (a, b: 2, 3);

Console.WriteLine($"The 1st element is {t123.Item1} (same as {t123.a}).");
Console.WriteLine($"The 2nd element is {t123.Item2} (same as {t123.b}).");
Console.WriteLine($"The 3rd element is {t123.Item3}.");






(int, double) t122 = (17, 3.14);
(double First, double Second) t222 = (0.0, 1.0);
t222 = t122;
Console.WriteLine($"{nameof(t222)}: {t222.First} and {t222.Second}");
// Output:
// t2: 17 and 3.14

(double A, double B) t322 = (2.0, 3.0);
t322 = t222;
Console.WriteLine($"{nameof(t322)}: {t322.A} and {t322.B}");
// Output:
// t3: 17 and 3.14









var t31 = ("post office", 3.6);
(string destination, double distance) = t31;
Console.WriteLine($"Distance to {destination} is {distance} kilometers.");
// Output:
// Distance to post office is 3.6 kilometers.






var t1233 = ("post office", 3.6);
var (destination2, distance2) = t1233;
Console.WriteLine($"Distance to {destination2} is {distance2} kilometers.");
// Output:
// Distance to post office is 3.6 kilometers.





var destination3 = string.Empty;
var distance3 = 0.0;

var t012 = ("post office", 3.6);
(destination3, distance3) = t012;
Console.WriteLine($"Distance to {destination3} is {distance3} kilometers.");
// Output:
// Distance to post office is 3.6 kilometers.








(int a, byte b) left = (5, 10);
(long a, int b) right = (5, 10);
Console.WriteLine(left == right);  // output: True
Console.WriteLine(left != right);  // output: False

var t122222 = (A: 5, B: 10);
var t222222 = (B: 5, A: 10);
Console.WriteLine(t122222 == t222222);  // output: True
Console.WriteLine(t122222 != t222222);  // output: False




Console.WriteLine((Display(1), Display(2)) == (Display(3), Display(4)));

int Display(int s)
{
    Console.WriteLine(s);
    return s;
}
// Output:
// 1
// 2
// 3
// 4
// False






var limitsLookup = new Dictionary<int, (int Min, int Max)>()
{
    [2] = (4, 10),
    [4] = (10, 20),
    [6] = (0, 23)
};

if (limitsLookup.TryGetValue(4, out (int Min, int Max) limits))
{
    Console.WriteLine($"Found limits: min is {limits.Min}, max is {limits.Max}");
}
// Output:
// Found limits: min is 10, max is 20