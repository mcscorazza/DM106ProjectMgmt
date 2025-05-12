using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt_Console
{
    internal class Project
    {
        public string Name { get; set; }
        public string DrawingCode { get; set; }
        public string Client { get; set; }
        private List<JobTask> JobTasks { get; set; } = new List<JobTask>();

        public Project(string name, string drawingCode, string client)
        {
            Name = name;
            DrawingCode = drawingCode;
            Client = client;
        }

        public override string ToString()
        {
            return $@"Projeto: {Name}";
        }
        public void AddTask(JobTask task)
        {
            JobTasks.Add(task);
        }

        public void showTasks()
        {
            if (JobTasks.Count > 0)
            {
                Console.WriteLine($"Tarefas do Projeto {Name}:");
                foreach (var task in JobTasks)
                {
                    Console.WriteLine(task);
                }
            }
            else
            {
                Console.WriteLine($"Não há tarefas registradas para o projeto {Name}.");
            }
        }
    }
}
