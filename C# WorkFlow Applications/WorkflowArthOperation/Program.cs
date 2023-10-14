using System;
using System.Activities;
using System.Collections.Generic;
namespace WorkflowArthOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wf = new Workflow1();
            IDictionary<string, object> inp = new Dictionary<string, object>();
            IDictionary<string, object> output = new Dictionary<string, object>();
            inp["arg1"] = 20;
            inp["arg2"] = 20;
            inp["opt"] = "Add";
            var wapp = new WorkflowApplication(wf, inp);
            wapp.Completed = e =>
            {
                output = e.Outputs;
                Activity av = new Workflow2();
                WorkflowInvoker.Invoke(av, output);
            };
            wapp.Run();
            Console.ReadKey();
        }
    }
}
