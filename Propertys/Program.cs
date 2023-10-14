using System;

namespace Properties
{
    class Circle
    {
        private double _Radius = 23.2;
        public double Radius
        {
            get { return _Radius; }
            set
            {
                if (value >= 0)
                {
                    _Radius = value;
                }
                else
                {
                    Console.WriteLine("Invalid radius value. Radius cannot be negative.");
                }
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine("Initial radius: " + c.Radius);
            c.Radius = 10.5;
            Console.WriteLine("Updated radius: " + c.Radius);
            c.Radius = -5.0; 
            Console.WriteLine("Radius after invalid update: " + c.Radius);
        }
    }
}
