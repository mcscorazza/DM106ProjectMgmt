using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DM106ProjectMgmt.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Cilindro Hidráulico", "CDH-001", "HydroTech" });

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Sistema de Transmissão", "STM-102", "Mecatron" });

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Base de Suporte", "BSP-300", "EnginPower" });

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Braço Robótico", "BRR-210", "AutoMech" });

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Conjunto de Eixos", "CEJ-511", "Torque Systems" });

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Carcaça do Motor", "CMR-900", "ElectroParts" });

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Suporte de Sensor", "SSS-113", "VisionRobotics" });

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Unidade de Resfriamento", "URF-721", "CoolTech" });

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Estrutura de Chassi", "ECH-845", "MetalShape" });

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" },
                new object[] { "Plataforma Elevatória", "PEL-128", "LiftCorp" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MachineDesign");
        }
    }
}
