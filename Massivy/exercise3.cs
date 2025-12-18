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
        int startIndex = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                bool isSymmetric = true;
                int length = j - i + 1;
                
                for (int k = 0; k < length / 2; k++)
                {
                    if (array[i + k] != array[j - k])
                    {
                        isSymmetric = false;
                        break;
                    }
                }
                
                if (isSymmetric && length > maxLength)
                {
                    maxLength = length;
                    startIndex = i;
                }
            }
        }
        
        Console.WriteLine("Максимальная симметричная подпоследовательность:");
        for (int i = startIndex; i < startIndex + maxLength; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\nДлина: " + maxLength);
    }
}