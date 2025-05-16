using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DM106ProjectMgmt.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaskDataEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Modelagem 3D Inicial", "Marcos", "Pendente", 1 });

            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Análise Estrutural", "Fernanda", "Em Progresso", 1 });

            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Revisão de Desenho Técnico", "João", "Concluído", 1 });

            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Validação de Componentes", "Aline", "Pendente", 4 });

            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Simulação Dinâmica", "Lucas", "Em Progresso", 5 });

            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Ajuste de Tolerâncias", "Renata", "Concluído", 2 });

            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Geração de Lista de Peças", "Carlos", "Pendente", 8 });

            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Elaboração de Manual Técnico", "Tatiane", "Em Progresso", 8 });

            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Preparação para Fabricação", "Henrique", "Concluído", 8 });

            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" },
                new object[] { "Validação Final do Projeto", "Paula", "Pendente", 8 });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM JobTask");
        }
    }
}
