using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Models
{
    public class Requirement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int MachineDesignId { get; set; } // Chave estrangeira para o projeto associado

        // Referência para o projeto associado
        public virtual MachineDesign? MachineDesign { get; set; }

        // Construtor da classe JobTask
        public Requirement(string description, string type, int designId )
        {
            Description = description;
            Type = type;
            MachineDesignId = designId;
        }

        // Sobrescreve o método ToString() para exibir informações da tarefa
        public override string ToString()
        {
            return $"| {Description,-50} | {Type,-15} |";
        }
    }
}
