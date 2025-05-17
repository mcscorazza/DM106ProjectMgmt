using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Models
{
    public class Components
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MachineDesign> Design { get; set; }

        public override string ToString()
        {
            return $@"| {Id} | {PartNumber} | {Description}";
        }

    }
}
