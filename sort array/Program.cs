using System;
using System.Diagnostics.CodeAnalysis;
class program
{
    static void Main()
    {
        int[] n = new int[10];
        int sum = 0;
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("enter {i+1}:");
            n[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(n);
        Array.Reverse(n);
        foreach (int i in n)
        {
            Console.Write(i);
        }
        Console.WriteLine("\n min={0}", n[n.Length-1]);
        Console.WriteLine(("\nmax={1}", n[0]));
        // calculate sum of all elements
        foreach (int i in n)
        { sum = sum + i;

        }
        Console.WriteLine("sum={0}", sum);
    }
}