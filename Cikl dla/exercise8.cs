using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи x: ");
        double x = double.Parse(Console.ReadLine());
		double result = 1;

        for (int i = 9; i >= 0; i--)
        {
            int coefficient = 11 - i;
            result = result * x + coefficient;
        }
        
        Console.WriteLine("Результат: " + result);
    }
}