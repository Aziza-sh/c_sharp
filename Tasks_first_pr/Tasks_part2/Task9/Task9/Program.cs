using System;

class Program
{
    static void Main()
    {
        int count = 0;

        do
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0) break;
            count++;
        } while (true);

        Console.WriteLine($"Введено чисел: {count}");

        /*
        int count = 0;
        while (true)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0) break;
            count++;
        }
        Console.WriteLine($"Введено чисел: {count}");
        */
    }
}