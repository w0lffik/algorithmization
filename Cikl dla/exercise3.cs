using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи начало отрезка a: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введи конец отрезка b: ");
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Числа Армстронга в отрезке [" + a + ", " + b + "]:");
        
        for (int number = a; number <= b; number++)
        {
            int sum = 0;
            int temp = number;
            int digitsCount = 0;
            
            while (temp > 0)
            {
                digitsCount++;
                temp /= 10;
            }
            
            temp = number;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digitsCount);
                temp /= 10;
            }

            if (sum == number)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
}