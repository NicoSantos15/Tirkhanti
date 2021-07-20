using Microsoft.EntityFrameworkCore.Migrations;

namespace Tirkhanti_R12.Migrations
{
    public partial class AddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckedBy",
                table: "LeaderChecked");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "LeaderChecked",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReportID",
                table: "LeaderChecked",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "LeaderAssignedReport",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReportID",
                table: "LeaderAssignedReport",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaderChecked_Id",
                table: "LeaderChecked",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_LeaderChecked_ReportID",
                table: "LeaderChecked",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaderAssignedReport_Id",
                table: "LeaderAssignedReport",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_LeaderAssignedReport_ReportID",
                table: "LeaderAssignedReport",
                column: "ReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaderAssignedReport_AspNetUsers_Id",
                table: "LeaderAssignedReport",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaderAssignedReport_StudentReport_ReportID",
                table: "LeaderAssignedReport",
                column: "ReportID",
                principalTable: "StudentReport",
                principalColumn: "ReportID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaderChecked_AspNetUsers_Id",
                table: "LeaderChecked",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaderChecked_StudentReport_ReportID",
                table: "LeaderChecked",
                column: "ReportID",
                principalTable: "StudentReport",
                principalColumn: "ReportID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaderAssignedReport_AspNetUsers_Id",
                table: "LeaderAssignedReport");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaderAssignedReport_StudentReport_ReportID",
                table: "LeaderAssignedReport");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaderChecked_AspNetUsers_Id",
                table: "LeaderChecked");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaderChecked_StudentReport_ReportID",
                table: "LeaderChecked");

            migrationBuilder.DropIndex(
                name: "IX_LeaderChecked_Id",
                table: "LeaderChecked");

            migrationBuilder.DropIndex(
                name: "IX_LeaderChecked_ReportID",
                table: "LeaderChecked");

            migrationBuilder.DropIndex(
                name: "IX_LeaderAssignedReport_Id",
                table: "LeaderAssignedReport");

            migrationBuilder.DropIndex(
                name: "IX_LeaderAssignedReport_ReportID",
                table: "LeaderAssignedReport");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "LeaderChecked");

            migrationBuilder.DropColumn(
                name: "ReportID",
                table: "LeaderChecked");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "LeaderAssignedReport");

            migrationBuilder.DropColumn(
                name: "ReportID",
                table: "LeaderAssignedReport");

            migrationBuilder.AddColumn<string>(
                name: "CheckedBy",
                table: "LeaderChecked",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
