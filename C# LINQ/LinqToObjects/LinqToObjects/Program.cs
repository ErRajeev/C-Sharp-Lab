using System;
using System.Linq;

class LinqToObjects
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Size of Array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        var res = (from x in arr select x).Sum();
        Console.WriteLine("Sum of all numbers: "+res);
        Console.ReadKey();
    }
}