using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek5_VirtualWorker
{
    // ProjectManager inherits from WorkerAvatar
    internal class ProjectManager : WorkerAvatar
    {
        public string ProjectName { get; set; }
        public string DepartmentName { get; set; }
        public string ProgramName { get; set; }

        public ProjectManager(string projectName, string departmentName, string programName)
        {
            ProjectName = projectName;
            DepartmentName = departmentName;
            ProgramName = programName;
        }

        public ProjectManager(string name, string description, int id, string projectName, string departmentName, string programName)
        {
            Name = name;
            Description = description;
            Id = id;
            ProjectName = projectName;
            DepartmentName = departmentName;
            ProgramName = programName;
        }

    }
}
