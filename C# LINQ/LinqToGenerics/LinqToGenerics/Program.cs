using System;
using System.Collections;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size of array");
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> al = new List<int>(n);

        // Use a for loop to populate the ArrayList
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter element " + (i + 1) + ":");
            int v = Convert.ToInt32(Console.ReadLine());
            al.Add(v);
        }

        var res = from x in al select x;
        Console.WriteLine("Resuts are :");
        foreach (var item in res)   
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}