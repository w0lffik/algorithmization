using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи номер числа Фибоначчи n: ");
        int n = int.Parse(Console.ReadLine());
        
        if (n <= 0)
        {
            Console.WriteLine("n должно быть натуральным числом");
            return;
        }
        
        if (n == 1 || n == 2)
        {
            Console.WriteLine("F" + n + " = 1");
            return;
        }
        
        long fib1 = 1; // F1
        long fib2 = 1; // F2
        long fibN = 0;
        
        for (int i = 3; i <= n; i++)
        {
            fibN = fib1 + fib2;
            fib1 = fib2;
            fib2 = fibN;
        }
        
        Console.WriteLine("F" + n + " = " + fibN);
    }
}