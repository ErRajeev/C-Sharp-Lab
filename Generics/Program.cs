/*using System;

namespace GenericsCollection
{
    class Demo<T>
    {
        public void add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            Console.WriteLine(da + db);
        }

        public void mult(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            Console.WriteLine(da * db);
        }

        public void div(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            Console.WriteLine(da / db);
        }
    }

    class Genericss
    {
        public static void Main(string[] args)
        {
            Demo<Int32> demo = new Demo<Int32>();
            demo.add(10, 20);
            demo.mult(10, 20);
            demo.div(10, 20);
        }
    }
}
*/


namespace den
{
    class MyArray<T>
    {
        private T[] array;
        public MyArray(int size) 
        {
            array = new T[size];
        }
        public T this[int index]
        {
            get { return array[index];}
            set { array[index] = value;}
        }
        public int Length
        {
            get { return array.Length; }
        }
    }

    class UseArray
    {
        public static void Main(string[] args)
        {
            MyArray<int> intArray = new MyArray<int>(5);
            MyArray<string> stringArray = new MyArray<string>(3);

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 10;
                Console.WriteLine($"intArray[{i}] = {intArray[i]}");
            }

            stringArray[0] = "Hello";
            stringArray[1] = "World";
            stringArray[2] = "C#";

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"stringArray[{i}] = {stringArray[i]}");
            }
        }
    }
}