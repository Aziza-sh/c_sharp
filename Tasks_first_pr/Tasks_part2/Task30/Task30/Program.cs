using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Дополнительный вариант (компактный):");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }

        /*
        int i = 1;
        while (i <= 10)
        {
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
                j++;
            }
            Console.WriteLine();
            i++;
        }

        Console.WriteLine("Дополнительный вариант (компактный):");

        i = 1;
        while (i <= 10)
        {
            int j = 1;
            while (j <= 10)
            {
                Console.Write($"{i * j,4}");
                j++;
            }
            Console.WriteLine();
            i++;
        }
        */
    }
}