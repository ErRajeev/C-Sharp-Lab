namespace DeligetsProjects
{
    public delegate void addDel(int a, int b);
    public delegate string helloDel(string name);
    class MyProgram
    {
        public void add(int a, int b)
        {
            Console.WriteLine($"Addition = {a + b}");
        }
        public static string hello(string name)
        {
            return ($"Hello {name}");
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            MyProgram del = new MyProgram();
            addDel ad = new addDel(del.add);
            helloDel hd = new helloDel(MyProgram.hello);
            ad(2, 8);
            Console.WriteLine(hd.Invoke("Rajeev"));

        }
    }
}
