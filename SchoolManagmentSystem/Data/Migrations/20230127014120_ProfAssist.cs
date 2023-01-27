using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagmentSystem.Data.Migrations
{
    public partial class ProfAssist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Assistants_ProfessorID",
                table: "Assistants");

            migrationBuilder.DropColumn(
                name: "AssistantID",
                table: "Professors");

            migrationBuilder.CreateIndex(
                name: "IX_Assistants_ProfessorID",
                table: "Assistants",
                column: "ProfessorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Assistants_ProfessorID",
                table: "Assistants");

            migrationBuilder.AddColumn<int>(
                name: "AssistantID",
                table: "Professors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Assistants_ProfessorID",
                table: "Assistants",
                column: "ProfessorID",
                unique: true);
        }
    }
}
