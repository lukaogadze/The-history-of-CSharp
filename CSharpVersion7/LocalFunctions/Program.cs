static void Sample()
{
    void InnerSample()
    {
        Console.WriteLine("Sample");
    }
    
    void InnerSample2(string message)
    {
        Console.WriteLine(message);
    }

    Delegate handler1 = InnerSample;
    Delegate handler2 = InnerSample2;
    handler2.Method.Invoke(handler2, new object?[] { "saddas" });


    InnerSample();
}

Sample();