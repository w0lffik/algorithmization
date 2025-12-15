using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введи координаты ферзя (x1, y1):");
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи координаты фигуры противника (x2, y2):");
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        bool sameRow = (x1 == x2);
        bool sameColumn = (y1 == y2);
        bool sameDiagonal = (Math.Abs(x1 - x2) == Math.Abs(y1 - y2));

        if (sameRow || sameColumn || sameDiagonal)
        {
            Console.WriteLine("Ферзь бьёт фигуру");
        }
        else
        {
            Console.WriteLine("Ферзь не бьёт фигуру");
        }
    }
}