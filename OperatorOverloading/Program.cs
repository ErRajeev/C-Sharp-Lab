using System;
class OperatorOverloading
{
    class Matrix
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix res = new Matrix(m1.a + m2.a, m1.b + m2.b, m1.c + m2.c, m1.d + m2.d);
            return res;
        }
        public override string ToString()
        {
            //return "Hello Rajeev";
            return $"{a}  {b}  {c}  {d}\n";
        }
    }

    public static void Main(string[] args)
    {
        Matrix obj1 = new Matrix(1, 2, 4, 4);
        Matrix obj2 = new Matrix(2, 4, 5, 6);
        Matrix obj3 = obj1 + obj2;
        Console.WriteLine(obj1);
        Console.WriteLine(obj2);
        Console.WriteLine(obj3);
    }
}