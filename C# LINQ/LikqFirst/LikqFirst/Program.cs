using System;
using System.Collections.Generic;
using System.Linq;

namespace LikqFirst
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] arr = { 10, 20, 30, 40, 50, 60 };

            var res = from i in arr where i > 20 select i;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
