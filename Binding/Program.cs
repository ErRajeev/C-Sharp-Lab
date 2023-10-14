/*
namespace EarlyBindingExample
{
    class MyClass
    {
        public int MyProperty { get; set; }
        public void display()
        {
            Console.WriteLine("Display Method is called.");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.display();
            obj.MyProperty = 10;
            Console.WriteLine(obj.MyProperty);
        }
    }
}*/


using System;

class GFG
{
    public static void Main()
    {
        // Dynamic objects
        dynamic obj = 4;
        dynamic obj1 = 5.678;

        // Display the type of objects
        Console.WriteLine("The type of the objects are :");

        // GetType() method is
        // used to get the type
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj1.GetType());
    }
}
