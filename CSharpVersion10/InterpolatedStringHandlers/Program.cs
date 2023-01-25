// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Text;

var attribute = "not awesome";
var processedMessage = ProcessMessage($"Code maze is {attribute}.");
string ProcessMessage(CustomInterpolatedStringHandler builder) => builder.GetFormattedText();

Console.WriteLine("Hello, World!");


[InterpolatedStringHandler]
public ref struct CustomInterpolatedStringHandler
{
    StringBuilder builder;
    public CustomInterpolatedStringHandler(int literalLength, int formattedCount)
    {
        builder = new StringBuilder(literalLength);
    }
    public void AppendLiteral(string s)
    {
        builder.Append(s);
    }
    public void AppendFormatted<T>(T t)
    {
        if (t is string)
        {
            var s = t?.ToString() ?? string.Empty;
            var notToken = "not ";
            var index = s.IndexOf(notToken);
            builder.Append(index < 0 ? s : s.Remove(index, notToken.Length));
        }
        else
        {
            builder.Append(t);
        }
    }
    public string GetFormattedText() => builder.ToString();
}