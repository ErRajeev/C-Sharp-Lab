using System;
using System.Collections;
using System.Collections.Generic;

/*
class Program
{
    public static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(10);
        arrayList.Add(20);
        arrayList.Add(15);
        arrayList.Add(5);

        Console.WriteLine(arrayList.Contains(20));

        arrayList.Sort();

        Console.WriteLine(arrayList.Count);

        Console.WriteLine("ArrayList Elements are...");
        foreach (int element in arrayList)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine($"Index of 10 is: {arrayList.IndexOf(10)}");

        arrayList.Clear();

        if (arrayList.Count == 0)
        {
            Console.WriteLine("ArrayList is empty");
        }
        else
        {
            Console.WriteLine("ArrayList is not empty");
        }

        arrayList.Add(30);
        arrayList.Add(40);

        arrayList.Insert(2, 25);

        Console.WriteLine("Updated ArrayList Elements are...");
        foreach (int element in arrayList)
        {
            Console.WriteLine(element);
        }

        arrayList.Remove(25);

        Console.WriteLine("After removing 25...");
        foreach (int element in arrayList)
        {
            Console.WriteLine(element);
        }
    }
}*/


/*class Program
{
    public static void Main(string[] args)
    {
        List<object> ls = new List<object>();
        ls.Add(100);
        ls.Add(200);
        ls.Add(150);
        ls.Add(50);

        Console.WriteLine(ls.Contains(20));

        ls.Sort();

        Console.WriteLine(ls.Count);

        Console.WriteLine("List Elements are...");
        foreach (int e in ls)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine($"index of 10 is : {ls.IndexOf(10)}");

        ls.Clear();

        if (ls.Count == 0)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Console.WriteLine("Not Empty");
        }
    }
}
*/

/*class Program
{
    public static void Main(string[] args)
    {
        HashSet<int> hashSet = new HashSet<int>();
        
        // Add elements to the HashSet
        hashSet.Add(10);
        hashSet.Add(20);
        hashSet.Add(15);
        hashSet.Add(5);

        // Check if an element exists in the HashSet
        Console.WriteLine(hashSet.Contains(20)); // Should print True

        // Count the number of elements in the HashSet
        Console.WriteLine(hashSet.Count); // Should print 4

        // Print the elements in the HashSet (unordered)
        Console.WriteLine("HashSet Elements are...");
        foreach (int element in hashSet)
        {
            Console.WriteLine(element);
        }

        // Remove an element from the HashSet
        hashSet.Remove(15);

        // Check if an element exists after removal
        Console.WriteLine(hashSet.Contains(15)); // Should print False

        // Clear the HashSet
        hashSet.Clear();

        // Check if the HashSet is empty
        if (hashSet.Count == 0)
        {
            Console.WriteLine("HashSet is empty");
        }
        else
        {
            Console.WriteLine("HashSet is not empty");
        }
    }
}*/

/*class Program
{
    public static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        
        // Push elements onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(15);
        stack.Push(5);

        // Peek at the top element (without removing it)
        int topElement = stack.Peek();
        Console.WriteLine("Top element: " + topElement); // Should print 5

        // Pop elements from the stack
        int poppedElement = stack.Pop();
        Console.WriteLine("Popped element: " + poppedElement); // Should print 5

        // Check if the stack contains an element
        bool containsElement = stack.Contains(15);
        Console.WriteLine("Contains 15: " + containsElement); // Should print True

        // Count the number of elements in the stack
        Console.WriteLine("Number of elements: " + stack.Count); // Should print 3

        // Iterate through the elements in the stack (in reverse order of insertion)
        Console.WriteLine("Stack Elements (in reverse order):");
        foreach (int element in stack)
        {
            Console.WriteLine(element);
        }

        // Clear the stack
        stack.Clear();

        // Check if the stack is empty
        if (stack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Stack is not empty");
        }
    }
}*/

/*
class Program
{
    public static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();

        // Enqueue (add) elements to the queue
        queue.Enqueue(44);
        queue.Enqueue(22);
        queue.Enqueue(13);
        queue.Enqueue(35);

        int frontElement = queue.Peek();
        Console.WriteLine("Front element: " + frontElement); // Should print 10

        int dequeuedElement = queue.Dequeue();
        Console.WriteLine("Dequeued element: " + dequeuedElement); // Should print 10

        bool containsElement = queue.Contains(15);
        Console.WriteLine("Contains 15: " + containsElement); // Should print True

        Console.WriteLine("Number of elements: " + queue.Count); // Should print 3

        Console.WriteLine("Queue Elements (in order of enqueue):");
        foreach (int element in queue)
        {
            Console.WriteLine(element);
        }

        queue.Clear();

        if (queue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("Queue is not empty");
        }
    }
}*/