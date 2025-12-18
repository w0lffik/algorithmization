using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи количество спортсменов: ");
        int n = int.Parse(Console.ReadLine());
        
        double[] results = new double[n];
        
        Console.WriteLine("Введи результаты забега (в секундах):");
        for (int i = 0; i < n; i++)
        {
            results[i] = double.Parse(Console.ReadLine());
        }
        
        double[] sortedResults = new double[n];
        Array.Copy(results, sortedResults, n);
        
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (sortedResults[j] < sortedResults[i])
                {
                    double temp = sortedResults[i];
                    sortedResults[i] = sortedResults[j];
                    sortedResults[j] = temp;
                }
            }
        }
        
        Console.WriteLine("\nКоманда из 4 лучших спортсменов:");
        for (int i = 0; i < Math.Min(4, n); i++)
        {
            int index = Array.IndexOf(results, sortedResults[i]);
            Console.WriteLine("Спортсмен #" + (index + 1) + ": " + sortedResults[i] + " секунд");
        }
    }
}