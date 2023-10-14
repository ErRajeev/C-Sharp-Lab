namespace Ano
{
    public delegate int Myadd();
    class Demo
    {
        public static void Main(string[] args)
        {
            Demo demo = new Demo();
            Myadd ma = delegate
            {
                return 2 + 2;
               // Console.WriteLine(133 + 30);
            };
            int res = ma.Invoke();
            Console.WriteLine(res);
        }
    }
}