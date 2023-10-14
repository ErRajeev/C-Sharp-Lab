using System;
namespace First
{
    class Attibutes
    {
        [Obsolete("You have the better Add Function", true)]
        public void add(int a, int b)
        {
            Console.WriteLine($"The Addition of {a} and {b} is  {a + b}");
            Console.ReadKey();
        }
        [Obsolete("You hame better Add Function", true)]
        public void add(int a, int b, int c)
        {
            Console.WriteLine($"The Addition of {a} and {b} and {c} is  {a + b + c }");
        }

        public void add(List<int> l)
        {
            int sum = 0;
            foreach (var item in l)
            {
                sum += item;
            }
            Console.WriteLine($"Sum of all element is {sum}");
        }

        public static void Main(string[] args)
        {
            Attibutes obj = new Attibutes();
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(n);
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.Read()));
            }
            obj.add(list);
            obj.add(10, 20);
            obj.add(73, 44, 46);
            //obj.add(new List<int> { 23, 43, 64, 144, 474, 244 });
        }
    }
}
