using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи размер первого массива: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] array1 = new int[n1];
        
        Console.WriteLine("Введи элементы первого массива:");
        for (int i = 0; i < n1; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        
        Console.Write("\nВведи размер второго массива: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] array2 = new int[n2];
        
        Console.WriteLine("Введи элементы второго массива:");
        for (int i = 0; i < n2; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }
        
        int commonCount = 0;
        
        for (int i = 0; i < n1; i++)
        {
            bool found = false;

            for (int j = 0; j < n2; j++)
            {
                if (array1[i] == array2[j])
                {
                    found = true;
                    break;
                }
            }
            
            if (found)
            {
                commonCount++;
            }
        }
        
        Console.WriteLine("\nКоличество элементов первого массива, которые есть во втором: " + commonCount);
    }
}