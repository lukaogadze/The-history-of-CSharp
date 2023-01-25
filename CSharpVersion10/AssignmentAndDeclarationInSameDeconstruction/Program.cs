// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static void GetTuples()
{
    string city = "Raleigh";
    int population = 458880;

    (city, population, double area) = QueryCityData("New York City");

    Console.WriteLine(city);
    Console.WriteLine(population);
    Console.WriteLine(area);
}

static (string, int, double) QueryCityData(string name)
{
    if (name == "New York City")
        return (name, 8175133, 468.48);

    return ("", 0, 0);
}