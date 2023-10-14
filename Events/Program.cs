namespace eventProgram
{
    public delegate string MyDel(string str);
    class Program
    {
       public event MyDel MyEvent;
       public Program() 
        {
            this.MyEvent += new MyDel(this.WelcomeMsg);
        }
        public string WelcomeMsg(string user)
        {
            return $"Wellcome {user}";
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            string res = p.WelcomeMsg("Rajeev Ranjan");
            Console.WriteLine(res);
        }

    }
}