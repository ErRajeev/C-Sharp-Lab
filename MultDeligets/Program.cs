
namespace Deligets
{
    public delegate void RectangleProperty(double a, double b);
    class Program1
    {
        public void Area(double h, double w)
        {
            Console.WriteLine($"Area of Rectangle is {h * w}");
        }
        public void Perameter(double h, double w)
        {
            Console.WriteLine($"Perameter of Rectangle is {2 * (h + w)}");
        }
        public static void Main(string[] args)
        {
            Program1 p = new Program1();
            RectangleProperty rp = p.Area;
            rp += p.Perameter;
            rp.Invoke(43, 54);
        }
    }
}