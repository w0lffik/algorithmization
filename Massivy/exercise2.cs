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
        
        int maxLength = 1;
        int currentLength = 1;
        int startIndex = 0;
        int maxStartIndex = 0;
        
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = startIndex;
                }
            }
            else
            {
                currentLength = 1;
                startIndex = i + 1;
            }
        }
        
        Console.WriteLine("Максимальная возрастающая подпоследовательность:");
        for (int i = maxStartIndex; i < maxStartIndex + maxLength; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\nДлина: " + maxLength);
    }
}