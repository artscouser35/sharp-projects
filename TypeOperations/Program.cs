namespace TypeOperations;
using System;

static class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        //Divide(5,0);
        int a = RoundAndCheck(double.MaxValue);
        Console.WriteLine(a);
        Console.WriteLine(double.MaxValue);
    }

    static double Divide(int a, double b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Divide by zero");
        }

        Console.WriteLine(a / b);

        return a / b;
    }

    static int RoundAndCheck(double value)
    {
        return checked((int)value);
    }
}





