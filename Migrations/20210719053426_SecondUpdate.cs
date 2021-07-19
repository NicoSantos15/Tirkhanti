using Microsoft.EntityFrameworkCore.Migrations;

namespace Tirkhanti_R12.Migrations
{
    public partial class SecondUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentReport_AspNetUsers_AssignedToId",
                table: "StudentReport");

            migrationBuilder.RenameColumn(
                name: "AssignedToId",
                table: "StudentReport",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_StudentReport_AssignedToId",
                table: "StudentReport",
                newName: "IX_StudentReport_FirstName");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentReport_AspNetUsers_FirstName",
                table: "StudentReport",
                column: "FirstName",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentReport_AspNetUsers_FirstName",
                table: "StudentReport");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "StudentReport",
                newName: "AssignedToId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentReport_FirstName",
                table: "StudentReport",
                newName: "IX_StudentReport_AssignedToId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentReport_AspNetUsers_AssignedToId",
                table: "StudentReport",
                column: "AssignedToId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
