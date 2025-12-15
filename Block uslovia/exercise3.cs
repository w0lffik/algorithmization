using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введи первое число:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи второе число:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи третье число:");
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        if (b > c)
        {
            int temp = b;
            b = c;
            c = temp;
        }
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("Числа в порядке возрастания: " + a + ", " + b + ", " + c);
    }
}