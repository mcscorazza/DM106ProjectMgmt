using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var MachineDesignDAL = new MachineDesignDAL(new DM106ProjectMgmtContext());
        var JobTaskDAL = new JobTaskDAL(new DM106ProjectMgmtContext());

        Dictionary<string, MachineDesign> DesignList = new();

        // Menu para cadastro dos projetos e tarefas
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Bem vindo ao Gerenciador de Projetos de Máquinas DM106!\n");
            Console.WriteLine("[ 1 ] Criar um novo projeto");
            Console.WriteLine("[ 2 ] Adicionar tarefa a um projeto existente");
            Console.WriteLine("[ 3 ] Listar todos os projetos");
            Console.WriteLine("[ 4 ] Listar tarefas de um projeto");
            Console.WriteLine("[-1 ] para sair\n ");
            Console.WriteLine("Escolha uma opção:");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case -1:
                    Console.WriteLine("Até mais!");
                    exit = true;
                    break;
                case 1:
                    ProjectCreation();
                    break;
                case 2:
                    TaskCreation();
                    break;
                case 3:
                    GetProjects();
                    break;
                case 4:
                    GetProjectTasks();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            //Thread.Sleep(3000);
            Console.WriteLine("\nPressione qualquer tecla...");
            Console.ReadKey();
            Console.Clear();
        }

        // Método para criar um novo projeto
        void ProjectCreation()
        {
            // Limpa o Console e Solicita os Dados do Novo Projeto
            Console.Clear();
            Console.WriteLine("Registro de Projetos\n");
            Console.Write("Digite o Nome do Projeto que deseja registrar: ");
            string name = Console.ReadLine();
            Console.Write($"Digite o Código de Desenho para o Projeto [{name}]: ");
            string drawingCode = Console.ReadLine();
            Console.Write($"Digite o Nome do Cliente para o Projeto [{name}]: ");
            string client = Console.ReadLine();

            // Instancia um novo projeto
            MachineDesign project = new(name, drawingCode, client);

            // Cria novo Projeto no DB
            MachineDesignDAL.Create(project);
            Console.WriteLine($"O Projeto [{name}] foi registrado com sucesso!");
        }

        // Método para Criar uma nova Tarefa de um Projeto
        void TaskCreation()
        {
            // Limpa o Console e Solicita o Nome do Projeto
            Console.Clear();
            Console.WriteLine("Registro de Tarefas\n");
            Console.Write("Digite o Nome do Projeto cuja Tarefa deseja registrar: ");
            string ProjectName = Console.ReadLine();

            // Verifica se o projeto existe
            if (DesignList.ContainsKey(ProjectName)) {
                Console.Write("Digite o Título da Tarefa: ");
                string title = Console.ReadLine();
                Console.Write("Digite o Nome do Responsável pela Tarefa: ");
                string owner = Console.ReadLine();
                Console.Write("Digite o Status da Tarefa: ");
                string status = Console.ReadLine();
                MachineDesign Project = DesignList[ProjectName];
                
                // Adiciona a nova tarefa ao projeto
                Project.AddTask(new JobTask(title, owner, status));
                Console.WriteLine($"A tarefa [{title}] foi registrada com sucesso no projeto [{ProjectName}]!");
            }
            else
            {
                Console.WriteLine($"O projeto [{ProjectName}] não existe.");
            }
        }

        // Método para listar todos os projetos
        void GetProjects()
        {
            Console.Clear();
            Console.WriteLine("Lista de Projetos\n");
            // Lê todos os projetos da tabela
            foreach (var project in MachineDesignDAL.Read())
            {
                Console.WriteLine(project);
            }
        }

        // Método para listar as tarefas de um projeto
        void GetProjectTasks()
        {
            // Limpa o Console e Solicita o Nome do Projeto
            Console.Clear();
            Console.WriteLine("Lista de Tarefas de um Projeto\n");
            Console.Write("Digite o Nome do Projeto que deseja consultar: ");
            string ProjectName = Console.ReadLine();
            // Verifica se o projeto existe
            if (DesignList.ContainsKey(ProjectName))
            {
                MachineDesign project = DesignList[ProjectName];
                project.showTasks();
            }
            else Console.WriteLine($"O projeto [{ProjectName}] não existe.");
        }
    }
}