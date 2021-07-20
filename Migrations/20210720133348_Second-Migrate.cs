using Microsoft.EntityFrameworkCore.Migrations;

namespace Tirkhanti_R12.Migrations
{
    public partial class SecondMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "StudentReport",
                newName: "EmotionID");

            migrationBuilder.AddColumn<int>(
                name: "StudentReportReportID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentReport_EmotionID",
                table: "StudentReport",
                column: "EmotionID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StudentReportReportID",
                table: "AspNetUsers",
                column: "StudentReportReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StudentReport_StudentReportReportID",
                table: "AspNetUsers",
                column: "StudentReportReportID",
                principalTable: "StudentReport",
                principalColumn: "ReportID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentReport_Emotion_EmotionID",
                table: "StudentReport",
                column: "EmotionID",
                principalTable: "Emotion",
                principalColumn: "EmotionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StudentReport_StudentReportReportID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentReport_Emotion_EmotionID",
                table: "StudentReport");

            migrationBuilder.DropIndex(
                name: "IX_StudentReport_EmotionID",
                table: "StudentReport");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StudentReportReportID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentReportReportID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "EmotionID",
                table: "StudentReport",
                newName: "Priority");
        }
    }
}
