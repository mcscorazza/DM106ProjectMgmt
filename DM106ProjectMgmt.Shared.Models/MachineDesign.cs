using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Models
{
    public class MachineDesign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DrawingCode { get; set; }
        public string Client { get; set; }

        public virtual ICollection<JobTask> JobTasks { get; set; } = new List<JobTask>();

        // Construtor da classe MachineDesign
        public MachineDesign(string name, string drawingCode, string client)
        {
            Name = name;
            DrawingCode = drawingCode;
            Client = client;
        }

        // Adiciona uma tarefa ao projeto
        public void AddTask(JobTask task)
        {
            JobTasks.Add(task);
        }

        // Mostra as tarefas do projeto
        public void showTasks()
        {
            if (JobTasks.Count > 0)
            {
                Console.WriteLine($"Tarefas do Projeto [{Name}]:");
                Console.WriteLine($"------------------------------------------------------------------------------------------");
                Console.WriteLine($"| TAREFA                                             | RESPONSÁVEL     |          STATUS |");
                Console.WriteLine($"|----------------------------------------------------|-----------------|-----------------|");
                foreach (var task in JobTasks)
                {
                    Console.WriteLine(task);
                }
                Console.WriteLine($"------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine($"Não há tarefas registradas para o projeto {Name}.");
            }
        }

        // Sobrescreve o método ToString() para exibir informações do projeto
        public override string ToString()
        {
            return $@"| {Id} | Projeto: {Name}";
        }

    }
}
