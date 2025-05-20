using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Models
{
    // Classe que representa um componente de projeto
    public class Components
    {
        // Atributos da classe Components
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }

        // Referência para o projeto ao qual o componente pertence
        public virtual ICollection<MachineDesign> MachineDesign { get; set; } 

        // Override do método ToString para exibir os detalhes do componente
        public override string ToString()
        {
            return $@"| {Id} | {PartNumber} | {Description}";
        }

    }
}
