using System;

public class Program
{
    public static void Main()
    {
        int count = 0;
        
        for (int ticket = 0; ticket <= 999999; ticket++)
        {
            int firstHalf = ticket / 1000;
            int secondHalf = ticket % 1000;
            
            int sum1 = 0;
            int sum2 = 0;

            int temp = firstHalf;
            for (int i = 0; i < 3; i++)
            {
                sum1 += temp % 10;
                temp /= 10;
            }
            

            temp = secondHalf;
            for (int i = 0; i < 3; i++)
            {
                sum2 += temp % 10;
                temp /= 10;
            }
            
            if (sum1 == sum2)
            {
                Console.WriteLine(ticket.ToString("D6"));
                count++;
            }
        }
        
        Console.WriteLine("Всего счастливых билетов: " + count);
    }
}