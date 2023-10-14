class Program
{
    public static void Main(string[] args)
    {
        var sum = (int[] values) =>
        {
            int sum = 0;
            foreach (var value in values)
                sum += value;
              
            return sum;
        };
        int[] sequence = { 1, 2, 3, 4, 5 };
        int total = sum(sequence);
        Console.WriteLine(total);
    }
}