using System;
class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        string[] s1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] A = new int[n1];
        for (int i = 0; i < n1; i++) A[i] = int.Parse(s1[i]);
        int n2 = int.Parse(Console.ReadLine());
        string[] s2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] B = new int[n2];
        for (int i = 0; i < n2; i++) B[i] = int.Parse(s2[i]);
        int[] C = new int[n1 + n2];
        int i1 = 0, i2 = 0, k = 0;
        while (i1 < n1 && i2 < n2)
        {
            if (A[i1] <= B[i2]) C[k++] = A[i1++];
            else C[k++] = B[i2++];
        }
        while (i1 < n1) C[k++] = A[i1++];
        while (i2 < n2) C[k++] = B[i2++];
        Console.WriteLine(string.Join(" ", C));
    }
}