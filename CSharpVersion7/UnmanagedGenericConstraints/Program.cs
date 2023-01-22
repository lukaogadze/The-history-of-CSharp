// See https://aka.ms/new-console-template for more information

static unsafe byte[] ToByteArray<T>(T argument) where T : unmanaged
{
    var size = sizeof(T);
    var result = new Byte[size];
    Byte* p = (byte*)&argument;
    for (var i = 0; i < size; i++)
        result[i] = *p++;
    return result;
}

Console.WriteLine("Hello, World!");

