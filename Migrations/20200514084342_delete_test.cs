using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstDbExercise.Migrations
{
    public partial class delete_test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_Asignees_AsigneeId",
                table: "Todo");

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_Asignees_AsigneeId",
                table: "Todo",
                column: "AsigneeId",
                principalTable: "Asignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_Asignees_AsigneeId",
                table: "Todo");

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_Asignees_AsigneeId",
                table: "Todo",
                column: "AsigneeId",
                principalTable: "Asignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
