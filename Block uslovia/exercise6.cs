using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введи день:");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи месяц:");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи год:");
        int year = int.Parse(Console.ReadLine());

        bool isCorrect = true;

        if (year < 1 || month < 1 || month > 12 || day < 1)
        {
            isCorrect = false;
        }
        else
        {
            int daysInMonth = 31;
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                daysInMonth = 30;
            }
            else if (month == 2)
            {
                bool isLeapYear = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
                daysInMonth = isLeapYear ? 29 : 28;
            }

            if (day > daysInMonth)
            {
                isCorrect = false;
            }
        }

        if (isCorrect)
        {
            Console.WriteLine("Дата корректна");
        }
        else
        {
            Console.WriteLine("Дата некорректна");
        }
    }
}