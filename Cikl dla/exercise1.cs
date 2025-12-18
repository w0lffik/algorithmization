using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи натуральное число n: ");
        int n = int.Parse(Console.ReadLine());
        
        long sum = 0;
        
        // Внешний цикл для суммирования
        for (int i = 1; i <= n; i++)
        {
            long product = 1;
            // Внутренний цикл для вычисления произведения i*(i+1)*...*(2i)
            for (int j = i; j <= 2 * i; j++)
            {
                product *= j;
            }
            sum += product;
        }
        
        Console.WriteLine("Результат: " + sum);
    }
}