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
        
        bool isSet = true;
        
        for (int i = 0; i < n; i++)
        {

            for (int j = i + 1; j < n; j++)
            {
                if (array[i] == array[j])
                {
                    isSet = false;
                    break;
                }
            }
            
            if (!isSet)
            {
                break;
            }
        }
        
        if (isSet)
        {
            Console.WriteLine("Элементы массива образуют множество (все уникальны)");
        }
        else
        {
            Console.WriteLine("Элементы массива НЕ образуют множество (есть повторения)");
        }
    }
}