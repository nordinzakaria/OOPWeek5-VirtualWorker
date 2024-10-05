using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek5_VirtualWorker
{
    internal class Program
    {
        // Main is the entry point.
        // we can use it to do unit/integration testing
        static void Main(string[] args)
        {
            WorkerList workerList = new WorkerList();
            WorkerAvatar worker = new WorkerAvatar("Ali", "Nice guy", 232300);

            ProjectManager pm1 = new ProjectManager("Ahmad", "Ok", 432, "Tesla", "Design", "R&D");

            // polymorphism at work here
            workerList.AddAvatar(pm1);
            workerList.AddAvatar(worker);
        }
    }
}
