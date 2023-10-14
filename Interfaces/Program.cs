interface IAnimal
{
    void Eat();
    void Walk();
}

interface IDog : IAnimal
{
    void Eyes();
}

class Bulldog : IDog
{
    public void Eat()
    {
        Console.WriteLine("Dogs can eat Biskits");
    }

    public void Walk()
    {
        Console.WriteLine("Dogs can walk");
    }

    public void Eyes()
    {
        Console.WriteLine("Dogs have two eyes");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Bulldog dog = new Bulldog();
        dog.Walk();
        dog.Eat();
        dog.Eyes();
    }
}
