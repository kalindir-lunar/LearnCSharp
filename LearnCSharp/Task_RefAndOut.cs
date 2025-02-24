using System.Threading.Channels;

namespace LearnCSharp;

public class Task_RefAndOut
{
    public static void Swap(ref int a, ref int b)
    {
        (b, a) = (a, b);
    }

    public static void Increment(int a, int b, out int result)
    {
        result = a + b;
    }
}