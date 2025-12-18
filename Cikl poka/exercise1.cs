using System;

public class Program
{
    public static void Main()
    {
        bool continueProgram = true;
        
        while (continueProgram)
        {
            Console.WriteLine("\n=== МЕНЮ ===");
            Console.WriteLine("1. Проверить, входит ли цифра в число");
            Console.WriteLine("2. Перевернуть число");
            Console.WriteLine("3. Проверить, является ли число Фибоначчи");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите задание (0-3): ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Task1();
                    break;
                    
                case "2":
                    Task2();
                    break;
                    
                case "3":
                    Task3();
                    break;
                    
                case "0":
                    continueProgram = false;
                    Console.WriteLine("Программа завершена.");
                    break;
                    
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
    
    static void Task1()
    {
        Console.WriteLine("\n=== Проверка цифры в числе ===");
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.Write("Введите цифру для поиска (0-9): ");
        int digit = int.Parse(Console.ReadLine());
        
        bool containsDigit = false;
        int tempNumber = Math.Abs(number);
        
        while (tempNumber > 0)
        {
            int lastDigit = tempNumber % 10;
            if (lastDigit == digit)
            {
                containsDigit = true;
                break;
            }
            tempNumber = tempNumber / 10;
        }
        
        if (number == 0 && digit == 0)
        {
            containsDigit = true;
        }
        
        if (containsDigit)
        {
            Console.WriteLine("Цифра " + digit + " входит в число " + number);
        }
        else
        {
            Console.WriteLine("Цифра " + digit + " НЕ входит в число " + number);
        }
    }
    
    static void Task2()
    {
        Console.WriteLine("\n=== Переворот числа ===");
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        
        int reversedNumber = 0;
        int tempNumber = Math.Abs(number);
        
        while (tempNumber > 0)
        {
            int lastDigit = tempNumber % 10;
            reversedNumber = reversedNumber * 10 + lastDigit;
            tempNumber = tempNumber / 10;
        }
        
        if (number < 0)
        {
            reversedNumber = -reversedNumber;
        }
        
        if (number == 0)
        {
            reversedNumber = 0;
        }
        
        Console.WriteLine("Исходное число: " + number);
        Console.WriteLine("Перевёрнутое число: " + reversedNumber);
    }
    
    static void Task3()
    {
        Console.WriteLine("\n=== Проверка числа Фибоначчи ===");
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number < 0)
        {
            Console.WriteLine("Число Фибоначчи не может быть отрицательным");
            return;
        }
        
        if (number == 0 || number == 1)
        {
            Console.WriteLine(number + " является числом Фибоначчи");
            return;
        }
        
        int a = 0;
        int b = 1;
        int nextFib = 0;
        
        while (nextFib < number)
        {
            nextFib = a + b;
            a = b;
            b = nextFib;
            
            if (nextFib == number)
            {
                Console.WriteLine(number + " является числом Фибоначчи");
                return;
            }
        }
        
        Console.WriteLine(number + " НЕ является числом Фибоначчи");
    }
}