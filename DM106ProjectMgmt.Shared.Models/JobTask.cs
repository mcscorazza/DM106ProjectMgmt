using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Models
{
    // Classe que representa uma tarefa de projeto
    public class JobTask
    {
        // Atributos da classe JobTask
        public int Id { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public string Status { get; set; }

        // Chave estrangeira para o projeto associado
        public int MachineDesignId { get; set; } 

        // Referência para o projeto associado
        public virtual MachineDesign? MachineDesign { get; set; }

        // Construtor da classe JobTask
        public JobTask(string title, string owner, string status, int machineDesignId)
        {
            Title = title;
            Owner = owner;
            Status = status;
            MachineDesignId = machineDesignId;
        }

        // Override do método ToString para exibir os detalhes da tarefa
        public override string ToString()
        {
            return $"| {Title,-50} | {Owner,-15} | {Status,15} |";
        }
    }
}
