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
        
        int maxCount = 0;
        int mostFrequentElement = array[0];
        
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
            
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentElement = array[i];
            }
        }
        
        Console.WriteLine("Элемент " + mostFrequentElement + " встречается максимальное число раз: " + maxCount);
    }
}