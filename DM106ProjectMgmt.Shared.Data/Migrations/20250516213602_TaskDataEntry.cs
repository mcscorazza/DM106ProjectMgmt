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
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Modelagem do Suporte", "Carlos", "Pendente", 1 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Análise FEM", "Fernanda", "Em Progresso", 1 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Ajuste de furação", "João", "Concluído", 1 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Revisão dimensional", "Paula", "Pendente", 1 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Preparar esboços técnicos", "Tatiane", "Em Progresso", 1 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Revisão de layout", "Henrique", "Pendente", 2 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Definir pontos de fixação", "Luana", "Em Progresso", 2 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Criar desenho de conjunto", "Bruno", "Concluído", 2 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Atualizar revisão do projeto", "Aline", "Pendente", 2 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Listar componentes comerciais", "João", "Concluído", 2 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Gerar PDF técnico", "Marcos", "Pendente", 3 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Organizar pastas do projeto", "Lucas", "Pendente", 3 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Simulação de esforços", "Fernanda", "Em Progresso", 3 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Inserir notas no desenho", "Tatiane", "Concluído", 3 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Revisar tolerâncias", "Carlos", "Pendente", 3 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Criar explode view", "Aline", "Em Progresso", 4 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Inserir roscas no 3D", "Paula", "Concluído", 4 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Exportar lista de peças", "João", "Pendente", 4 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Gerar DWG", "Tatiane", "Concluído", 4 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Validar furação do suporte", "Lucas", "Em Progresso", 4 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Avaliar sistema de acionamento", "Henrique", "Pendente", 5 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Especificar motor", "Carlos", "Concluído", 5 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Criar simulação cinemática", "Marcos", "Pendente", 5 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Testar encaixe dos componentes", "Paula", "Em Progresso", 5 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Revisar desenho final", "Luana", "Concluído", 5 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Desenhar base de apoio", "Bruno", "Pendente", 6 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Estudo de material", "Aline", "Em Progresso", 6 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Otimizar fixação", "Fernanda", "Concluído", 6 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Criar protótipo digital", "João", "Em Progresso", 6 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Estudo de interferências", "Tatiane", "Pendente", 6 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Verificar normas aplicáveis", "Lucas", "Concluído", 7 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Simulação estrutural", "Carlos", "Pendente", 7 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Gerar documentação técnica", "Marcos", "Em Progresso", 7 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Exportar para PDF", "Henrique", "Concluído", 7 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Preparar para apresentação", "Aline", "Pendente", 7 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Ajuste final da estrutura", "Luana", "Em Progresso", 8 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Simular uso em campo", "Bruno", "Pendente", 8 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Definir parafuso ideal", "Fernanda", "Concluído", 8 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Atualizar layout 2D", "Paula", "Pendente", 8 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Verificar posição do eixo", "Marcos", "Em Progresso", 8 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Organizar arquivos CAD", "Carlos", "Pendente", 9 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Validar com cliente", "Fernanda", "Concluído", 9 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Avaliar desgaste de material", "Tatiane", "Pendente", 9 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Inserir sensor no projeto", "Lucas", "Em Progresso", 9 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Gerar explodido final", "Henrique", "Concluído", 9 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Finalizar ficha técnica", "Bruno", "Pendente", 10 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Ajustar geometria do eixo", "Aline", "Em Progresso", 10 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Montagem do protótipo", "Carlos", "Concluído", 10 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Testes funcionais", "Fernanda", "Pendente", 10 });
            migrationBuilder.InsertData("JobTask", new[] { "Title", "Owner", "Status", "MachineDesignId" }, new object[] { "Entrega ao cliente", "João", "Concluído", 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM JobTask");
        }
    }
}
