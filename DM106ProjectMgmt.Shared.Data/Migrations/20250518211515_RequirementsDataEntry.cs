using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DM106ProjectMgmt.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataEntryRequirements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Deve suportar até 10 toneladas de carga", "Funcional", 1 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Utilizar material inoxidável", "Técnico", 1 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Proteção contra corrosão ambiental", "Segurança", 1 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Tolerância máxima de 0.2mm", "Técnico", 1 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Permitir manutenção rápida", "Funcional", 1 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Atingir 3000 RPM", "Técnico", 2 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Conectores devem seguir padrão ISO", "Normativo", 2 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Isolamento térmico nas partes externas", "Segurança", 2 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Montagem deve ser modular", "Funcional", 2 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Deve funcionar entre -10°C e 50°C", "Técnico", 2 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Pintura anticorrosiva", "Técnico", 3 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Compatível com o sistema de fixação padrão", "Normativo", 3 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Detecção automática de falhas", "Funcional", 3 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Resistência a impactos de até 5kN", "Segurança", 3 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Vedação contra poeira e água (IP65)", "Técnico", 3 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Interface de controle via painel touch", "Funcional", 4 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Sistema de frenagem de emergência", "Segurança", 4 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Fácil integração com CLPs", "Técnico", 4 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Indicação sonora de erro", "Funcional", 4 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Funcionamento contínuo por 12h/dia", "Técnico", 4 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Compatível com motores NEMA 17", "Técnico", 5 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Sistema de lubrificação automática", "Funcional", 5 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Redução de ruído inferior a 60 dB", "Técnico", 5 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Trava de segurança mecânica", "Segurança", 5 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Manutenção programada a cada 6 meses", "Funcional", 5 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Sinalização luminosa de status", "Funcional", 6 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Fonte de alimentação 24V DC", "Técnico", 6 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Certificação NR-12", "Normativo", 6 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Autodiagnóstico ao ligar", "Funcional", 6 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Deve resistir à vibração contínua", "Segurança", 6 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Tempo de resposta inferior a 100ms", "Técnico", 7 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Calibração automática", "Funcional", 7 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Detecção de temperatura excessiva", "Segurança", 7 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Display digital integrado", "Técnico", 7 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Sinal de falha em caso de curto", "Segurança", 7 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Conector padrão M12", "Técnico", 8 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Capacidade de transmissão sem fio", "Funcional", 8 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Alerta visual de superaquecimento", "Segurança", 8 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Sistema de backup de energia", "Funcional", 8 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Revestimento resistente a solventes", "Técnico", 8 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Log de operação diário", "Funcional", 9 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Precisão de medição de 0.01mm", "Técnico", 9 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Desligamento automático após 10 min inativo", "Funcional", 9 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Operação segura em ambientes úmidos", "Segurança", 9 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Interface com sistemas SCADA", "Técnico", 9 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Temperatura operacional entre -5°C e 60°C", "Técnico", 10 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Sistema redundante de controle", "Funcional", 10 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Compatibilidade com rede Modbus", "Técnico", 10 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Dispositivo de parada de emergência", "Segurança", 10 });
            migrationBuilder.InsertData("Requirement", new[] { "Description", "Type", "MachineDesignId" }, new object[] { "Porta USB para atualização de firmware", "Funcional", 10 });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Requirement");
        }
    }
}
