using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Models
{
    // Classe que representa um requisito de projeto
    public class Requirement
    {
        // Atributos da classe Requirement
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        // Chave estrangeira para o projeto associado
        public int MachineDesignId { get; set; }

        // Referência para o projeto associado
        public virtual MachineDesign? MachineDesign { get; set; }

        // Construtor da classe Requirement
        public Requirement(string description, string type, int machineDesignId )
        {
            Description = description;
            Type = type;
            MachineDesignId = machineDesignId;
        }

        // Override do método ToString() para exibir informações do requisito
        public override string ToString()
        {
            return $"| {Description,-50} | {Type,-15} |";
        }
    }
}
