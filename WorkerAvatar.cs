using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek5_VirtualWorker
{
    internal class WorkerAvatar
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Id { get; set; }

        public Position CurrPosition { get; set; }

        public WorkerAvatar(string name, string description, int id)
        {  Name = name; Description = description; Id = id; }

        public WorkerAvatar() { }
    }
}
