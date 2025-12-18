using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи начало отрезка a: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введи конец отрезка b: ");
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Пары дружественных чисел в отрезке [" + a + ", " + b + "]:");
        
        for (int num1 = a; num1 <= b; num1++)
        {
            int sum1 = 0;
            for (int i = 1; i <= num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    sum1 += i;
                }
            }
            
            if (sum1 >= a && sum1 <= b && sum1 > num1)
            {
                int sum2 = 0;
                for (int i = 1; i <= sum1 / 2; i++)
                {
                    if (sum1 % i == 0)
                    {
                        sum2 += i;
                    }
                }
                
                if (sum2 == num1)
                {
                    Console.WriteLine("(" + num1 + ", " + sum1 + ")");
                }
            }
        }
    }
}