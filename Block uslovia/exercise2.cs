using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введи первое число:");
        int numberOne = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи второе число:");
        int numberTwo = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи третье число:");
        int numberThree = int.Parse(Console.ReadLine());

        int max = numberOne;

        if (numberTwo > max) max = numberTwo;
        if (numberThree > max) max = numberThree;

        Console.WriteLine("Максимальное число: " + max);
    }
}