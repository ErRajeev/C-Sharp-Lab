class IndexerCreation
{
    private string[] val = new string[10];
    public string this[int index]
    {
        get
        {
            return val[index];
        }
        set
        {
            val[index] = value;
        }
    }
}
class Program
{
    public static void Main()
    {
        IndexerCreation ic = new IndexerCreation();
        ic[0] = "Kumar";
        ic[1] = "Khan";
        ic[2] = "Ranjan";

        Console.Write("Printing values stored in objects used as arrays\n");
        Console.WriteLine($"First value = {ic[0]}");
        Console.WriteLine($"Second value = {ic[1]}");
        Console.WriteLine($"Third value = {ic[2]}");

    }
}
