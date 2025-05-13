using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Models;

internal class Program
{
    private static Dictionary<string, MachineDesign> DesignList = new();
    private static void Main(string[] args)
    {
        try
        {
            using var connection = new Connection().Connect();
            connection.Open();
            Console.WriteLine(connection.State);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        return;
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

            switch (option) {
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
    }

    private static void GetProjectTasks()
    {
        Console.Clear();
        Console.WriteLine("Lista de Tarefas de um Projeto\n");
        Console.Write("Digite o Nome do Projeto que deseja consultar: ");
        string projectName = Console.ReadLine();
        if (DesignList.ContainsKey(projectName))
        {
            MachineDesign p = DesignList[projectName];
            p.showTasks();
        }
        else
        {
            Console.WriteLine($"O projeto [{projectName}] não existe.");
        }
    }

    private static void GetProjects()
    {
        Console.Clear();
        Console.WriteLine("Lista de Projetos\n");
        foreach (var project in DesignList.Values)
        {
            Console.WriteLine(project);
        }
    }

    private static void TaskCreation()
    {
        Console.Clear();
        Console.WriteLine("Registro de Tarefas\n");
        Console.Write("Digite o Nome do Projeto cuja Tarefa deseja registrar: ");
        string projectName = Console.ReadLine();
        if (DesignList.ContainsKey(projectName))
        {
            MachineDesign p = DesignList[projectName];
            Console.Write("Digite o Título da Tarefa: ");
            string title = Console.ReadLine();
            Console.Write("Digite o Nome do Responsável pela Tarefa: ");
            string owner = Console.ReadLine();
            Console.Write("Digite o Status da Tarefa: ");
            string status = Console.ReadLine();
            p.AddTask(new JobTask(title, owner, status));
            Console.WriteLine($"A tarefa [{title}] foi registrada com sucesso no projeto [{projectName}]!");
        }
        else
        {
            Console.WriteLine($"O projeto [{projectName}] não existe.");
        }

    }

    private static void ProjectCreation()
    {
        Console.Clear();
        Console.WriteLine("Registro de Projetos\n");
        Console.Write("Digite o Nome do Projeto que deseja registrar: ");
        string name = Console.ReadLine();
        Console.Write($"Digite o Código de Desenho para o Projeto [{name}]: ");
        string drawingCode = Console.ReadLine();
        Console.Write($"Digite o Nome do Cliente para o Projeto [{name}]: ");
        string client = Console.ReadLine();
        MachineDesign project = new MachineDesign(name, drawingCode, client);
        DesignList.Add(name, project);
        Console.WriteLine($"O Projeto [{name}] foi registrado com sucesso!");
    }
}
