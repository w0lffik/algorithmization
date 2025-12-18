using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи число n: ");
        int n = int.Parse(Console.ReadLine());
        
        long result = 1;
        
        if (n % 2 == 0) // Четное n
        {
            for (int i = 2; i <= n; i += 2)
            {
                result *= i;
            }
        }
        else // Нечетное n
        {
            for (int i = 1; i <= n; i += 2)
            {
                result *= i;
            }
        }
        
        Console.WriteLine(n + "!! = " + result);
    }
}