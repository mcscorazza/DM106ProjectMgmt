using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DM106ProjectMgmt.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateComponents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentMachineDesign");

            migrationBuilder.CreateTable(
                name: "ComponentsMachineDesign",
                columns: table => new
                {
                    ComponentsId = table.Column<int>(type: "int", nullable: false),
                    DesignId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentsMachineDesign", x => new { x.ComponentsId, x.DesignId });
                    table.ForeignKey(
                        name: "FK_ComponentsMachineDesign_Components_ComponentsId",
                        column: x => x.ComponentsId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentsMachineDesign_MachineDesign_DesignId",
                        column: x => x.DesignId,
                        principalTable: "MachineDesign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentsMachineDesign_DesignId",
                table: "ComponentsMachineDesign",
                column: "DesignId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentsMachineDesign");

            migrationBuilder.CreateTable(
                name: "ComponentMachineDesign",
                columns: table => new
                {
                    ComponentsId = table.Column<int>(type: "int", nullable: false),
                    DesignId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentMachineDesign", x => new { x.ComponentsId, x.DesignId });
                    table.ForeignKey(
                        name: "FK_ComponentMachineDesign_Components_ComponentsId",
                        column: x => x.ComponentsId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentMachineDesign_MachineDesign_DesignId",
                        column: x => x.DesignId,
                        principalTable: "MachineDesign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentMachineDesign_DesignId",
                table: "ComponentMachineDesign",
                column: "DesignId");
        }
    }
}
