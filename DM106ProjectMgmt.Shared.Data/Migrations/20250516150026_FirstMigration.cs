using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.Metrics;

#nullable disable

namespace DM106ProjectMgmt.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MachineDesign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrawingCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineDesign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MachineDesignId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTask_MachineDesign_MachineDesignId",
                        column: x => x.MachineDesignId,
                        principalTable: "MachineDesign",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobTask_MachineDesignId",
                table: "JobTask",
                column: "MachineDesignId");

            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Cilindro Hidráulico", "CDH-001", "HydroTech" });
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Sistema de Transmissão", "STM-102", "Mecatron" });
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Base de Suporte", "BSP-300", "EnginPower" });
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Braço Robótico", "BRR-210", "AutoMech" });
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Conjunto de Eixos", "CEJ-511", "Torque Systems" });
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Carcaça do Motor", "CMR-900", "ElectroParts" });
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Suporte de Sensor", "SSS-113", "VisionRobotics" });
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Unidade de Resfriamento", "URF-721", "CoolTech" });
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Estrutura de Chassi", "ECH-845", "MetalShape" });
            migrationBuilder.InsertData("MachineDesign", new[] { "Name", "DrawingCode", "Client" }, new object[] { "Plataforma Elevatória", "PEL-128", "LiftCorp" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobTask");

            migrationBuilder.DropTable(
                name: "MachineDesign");

            migrationBuilder.Sql("DELETE FROM MachineDesign");
            
        }
    }
}
