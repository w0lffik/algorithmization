using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введи координаты коня (x1, y1):");
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи координаты фигуры противника (x2, y2):");
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        int dx = Math.Abs(x1 - x2);
        int dy = Math.Abs(y1 - y2);

        if ((dx == 1 && dy == 2) || (dx == 2 && dy == 1))
        {
            Console.WriteLine("Конь бьёт фигуру");
        }
        else
        {
            Console.WriteLine("Конь не бьёт фигуру");
        }
    }
}