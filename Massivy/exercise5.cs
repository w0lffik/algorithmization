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
        
        int uniqueCount = 0;
        
        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = 0; j < n; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }

            if (count == 1)
            {
                uniqueCount++;
            }
        }
        
        Console.WriteLine("Количество элементов, встречающихся по одному разу: " + uniqueCount);
    }
}