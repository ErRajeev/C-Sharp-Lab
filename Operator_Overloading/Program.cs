class Number
{
    private int value;
    public Number(int value)
    {
        this.value = value;
    }
    public static Number operator -(Number num)
    {
        return new Number(-num.value);
    }
    public void Display()
    {
        Console.WriteLine($"Value: {value}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Number num1 = new Number(10);
        Number num2 = -num1;

        Console.WriteLine("Original Number:");
        num1.Display();

        Console.WriteLine("Number after Unary - Overload:");
        num2.Display();
    }
}
