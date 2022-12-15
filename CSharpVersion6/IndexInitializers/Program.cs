namespace IndexInitializers;

public class IndexableClass
{
    public int this[int index]
    {
        set { Console.WriteLine("{0} was assigned to index {1}", value, index); }
    }

    public IndexableClass()
    {
        var dict1 = new Dictionary<string, int>
        {
            { "key1", 1 },
            { "key2", 50 }
        };
        
        var dict2 = new Dictionary<string, int>
        {
            ["key1"] = 1,
            ["key2"] = 50
        };

        var indexable = new IndexableClass()
        {
            [0] = 22,
        };
    }
}