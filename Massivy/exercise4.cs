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
        
        int[] dp = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;
        }
        
        int maxLength = 1;
        
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] < array[i] && dp[j] + 1 > dp[i])
                {
                    dp[i] = dp[j] + 1;
                }
            }
            
            if (dp[i] > maxLength)
            {
                maxLength = dp[i];
            }
        }
        
        Console.WriteLine("Длина максимальной возрастающей подпоследовательности: " + maxLength);
    }
}