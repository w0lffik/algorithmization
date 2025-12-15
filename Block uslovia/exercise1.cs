using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int numberOne = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int numberTwo = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите третье число:");
        int numberThree = int.Parse(Console.ReadLine());

        int evenCount = 0;

        if (numberOne % 2 == 0) evenCount++;
        if (numberTwo % 2 == 0) evenCount++;
        if (numberThree % 2 == 0) evenCount++;

        if (evenCount == 1)
        {
            Console.WriteLine("истина");
        }
        else
        {
            Console.WriteLine("ложь");
        }
    }
}