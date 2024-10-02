using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek5_VirtualWorker
{
    internal class WorkerList
    {
        private List<WorkerAvatar> avatars;

        public WorkerList()
        {
            avatars = new List<WorkerAvatar>();
        }

        public void AddAvatar(WorkerAvatar avatar)
        {
            avatars.Add(avatar);
        }

        public void RemoveAvatar(WorkerAvatar avatar)
        {
            avatars.Remove(avatar);
        }

        public void Display()
        {
            foreach (WorkerAvatar avatar in avatars)
            {
                Console.WriteLine(avatar.Name);
            }
        }
    }
}
