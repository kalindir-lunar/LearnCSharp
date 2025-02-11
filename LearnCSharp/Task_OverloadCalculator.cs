using System.Reflection.Emit;

class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Add(int a, int b, int c) => a + b + c;
    public static int Subtraction(int a, int b) => a - b;
    public static int Multiplication(int a, int b) => a * b;
    public static int Divide(int a, int b)
    {
        return a / b;
    }
}