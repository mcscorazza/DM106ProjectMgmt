using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DM106ProjectMgmt.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentsMachineDesign_MachineDesign_DesignId",
                table: "ComponentsMachineDesign");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTask_MachineDesign_MachineDesignId",
                table: "JobTask");

            migrationBuilder.DropForeignKey(
                name: "FK_Requirement_MachineDesign_MachineDesignId",
                table: "Requirement");

            migrationBuilder.RenameColumn(
                name: "DesignId",
                table: "ComponentsMachineDesign",
                newName: "MachineDesignId");

            migrationBuilder.RenameIndex(
                name: "IX_ComponentsMachineDesign_DesignId",
                table: "ComponentsMachineDesign",
                newName: "IX_ComponentsMachineDesign_MachineDesignId");

            migrationBuilder.AlterColumn<int>(
                name: "MachineDesignId",
                table: "Requirement",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MachineDesignId",
                table: "JobTask",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentsMachineDesign_MachineDesign_MachineDesignId",
                table: "ComponentsMachineDesign",
                column: "MachineDesignId",
                principalTable: "MachineDesign",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTask_MachineDesign_MachineDesignId",
                table: "JobTask",
                column: "MachineDesignId",
                principalTable: "MachineDesign",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requirement_MachineDesign_MachineDesignId",
                table: "Requirement",
                column: "MachineDesignId",
                principalTable: "MachineDesign",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentsMachineDesign_MachineDesign_MachineDesignId",
                table: "ComponentsMachineDesign");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTask_MachineDesign_MachineDesignId",
                table: "JobTask");

            migrationBuilder.DropForeignKey(
                name: "FK_Requirement_MachineDesign_MachineDesignId",
                table: "Requirement");

            migrationBuilder.RenameColumn(
                name: "MachineDesignId",
                table: "ComponentsMachineDesign",
                newName: "DesignId");

            migrationBuilder.RenameIndex(
                name: "IX_ComponentsMachineDesign_MachineDesignId",
                table: "ComponentsMachineDesign",
                newName: "IX_ComponentsMachineDesign_DesignId");

            migrationBuilder.AlterColumn<int>(
                name: "MachineDesignId",
                table: "Requirement",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MachineDesignId",
                table: "JobTask",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentsMachineDesign_MachineDesign_DesignId",
                table: "ComponentsMachineDesign",
                column: "DesignId",
                principalTable: "MachineDesign",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTask_MachineDesign_MachineDesignId",
                table: "JobTask",
                column: "MachineDesignId",
                principalTable: "MachineDesign",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requirement_MachineDesign_MachineDesignId",
                table: "Requirement",
                column: "MachineDesignId",
                principalTable: "MachineDesign",
                principalColumn: "Id");
        }
    }
}
