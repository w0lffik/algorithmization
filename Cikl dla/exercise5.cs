using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи x: ");
        double x = double.Parse(Console.ReadLine());
        
        Console.Write("Введи n: ");
        int n = int.Parse(Console.ReadLine());
        
        double result = 1;
        
        if (n >= 0)
        {
            for (int i = 0; i < n; i++)
            {
                result *= x;
            }
        }
        else
        {
            for (int i = 0; i < -n; i++)
            {
                result *= x;
            }
            result = 1 / result;
        }
        
        Console.WriteLine(x + "^" + n + " = " + result);
    }
}