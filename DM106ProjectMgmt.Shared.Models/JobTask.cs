using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Models
{
    public class JobTask
    {
        public string Title { get; set; }
        public string Owner { get; set; }
        public string Status { get; set; }

        // Construtor da classe JobTask
        public JobTask(string title, string owner, string status)
        {
            Title = title;
            Owner = owner;
            Status = status;
        }

        // Sobrescreve o método ToString() para exibir informações da tarefa
        public override string ToString()
        {
            return $"| {Title,-50} | {Owner,-15} | {Status,15} |";
        }
    }
}
