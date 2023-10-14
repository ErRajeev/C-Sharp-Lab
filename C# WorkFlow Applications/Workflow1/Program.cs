using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace Workflow1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Activity w = new Workflow1();
            WorkflowInvoker.Invoke(w);
            Console.ReadLine();
        }
    }
}
