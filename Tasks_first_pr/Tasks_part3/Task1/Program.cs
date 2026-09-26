using System;
using System.Text;

namespace ArrayTasks
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 4, 7, 1, 9, 2, 3, 4, 5, 6, 7 };
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
                if (i < arr.Length - 1) sb.Append(' ');
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
