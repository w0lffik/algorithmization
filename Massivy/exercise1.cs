using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи размер массива: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] array = new int[n];
        
        Console.WriteLine("Введи элементы массива:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        bool isIncreasing = true;
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] >= array[i + 1])
            {
                isIncreasing = false;
                break;
            }
        }
        
        if (isIncreasing)
        {
            Console.WriteLine("Массив является возрастающей последовательностью");
        }
        else
        {
            Console.WriteLine("Массив НЕ является возрастающей последовательностью");
        }
    }
}