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
        
        int distinctCount = 0;
        
        for (int i = 0; i < n; i++)
        {
            bool isNew = true;
            
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isNew = false;
                    break;
                }
            }
            
            if (isNew)
            {
                distinctCount++;
            }
        }
        
        Console.WriteLine("Количество различных элементов: " + distinctCount);
    }
}