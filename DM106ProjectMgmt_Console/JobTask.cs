using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt_Console
{
    internal class JobTask
    {
        public string Title { get; set; }
        public string Owner { get; set; }
        public string Status { get; set; }

        public JobTask(string title, string owner, string status)
        {
            Title = title;
            Owner = owner;
            Status = status;
        }
        public override string ToString()
        {
            return $@"Tarefa: {Title}, Resp.: {Owner}, Status: {Status}";
        }
    }

}
