using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int positive = 0;
        int negative = 0;
        int zero = 0;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x > 0) positive++;
            else if (x < 0) negative++;
            else zero++;

            sum += x;
        }

        Console.WriteLine($"Положительных: {positive}");
        Console.WriteLine($"Отрицательных: {negative}");
        Console.WriteLine($"Нулей: {zero}");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Среднее: {(double)sum / n}");

        /*
        int positive = 0;
        int negative = 0;
        int zero = 0;
        int sum = 0;
        int i = 0;

        while (i < n)
        {
            int x = int.Parse(Console.ReadLine());

            if (x > 0) positive++;
            else if (x < 0) negative++;
            else zero++;

            sum += x;
            i++;
        }

        Console.WriteLine($"Положительных: {positive}");
        Console.WriteLine($"Отрицательных: {negative}");
        Console.WriteLine($"Нулей: {zero}");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Среднее: {(double)sum / n}");
        */
    }
}