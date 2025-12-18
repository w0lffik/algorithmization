using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи размер первого множества: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] set1 = new int[n1];
        
        Console.WriteLine("Введи элементы первого множества:");
        for (int i = 0; i < n1; i++)
        {
            set1[i] = int.Parse(Console.ReadLine());
        }
        
        Console.Write("\nВведи размер второго множества: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] set2 = new int[n2];
        
        Console.WriteLine("Введи элементы второго множества:");
        for (int i = 0; i < n2; i++)
        {
            set2[i] = int.Parse(Console.ReadLine());
        }
        
        bool areEqual = true;
        
        for (int i = 0; i < n1; i++)
        {
            bool found = false;
            for (int j = 0; j < n2; j++)
            {
                if (set1[i] == set2[j])
                {
                    found = true;
                    break;
                }
            }
            
            if (!found)
            {
                areEqual = false;
                break;
            }
        }
        
        if (areEqual)
        {
            for (int i = 0; i < n2; i++)
            {
                bool found = false;
                for (int j = 0; j < n1; j++)
                {
                    if (set2[i] == set1[j])
                    {
                        found = true;
                        break;
                    }
                }
                
                if (!found)
                {
                    areEqual = false;
                    break;
                }
            }
        }
        
        if (areEqual)
        {
            Console.WriteLine("Множества равны");
        }
        else
        {
            Console.WriteLine("Множества НЕ равны");
        }
    }
}