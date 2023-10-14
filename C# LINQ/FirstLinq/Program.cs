using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        IList<string> names = new List<string>();
        names.Add("Rajeev");
        names.Add("Ranjan");
        names.Add("Kumar");

        var name = from  name in names where word.Contains("Rajeev") select word;
        foreach (var item in name)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}