using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введи число от 1 до 999:");
        int number = int.Parse(Console.ReadLine());

        string wordForm = "рублей";
        int lastDigit = number % 10;
        int lastTwoDigits = number % 100;

        if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
        {
            wordForm = "рублей";
        }
        else if (lastDigit == 1)
        {
            wordForm = "рубль";
        }
        else if (lastDigit >= 2 && lastDigit <= 4)
        {
            wordForm = "рубля";
        }

        Console.WriteLine(number + " " + wordForm);
    }
}