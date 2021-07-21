using Microsoft.EntityFrameworkCore.Migrations;

namespace Tirkhanti_R12.Migrations
{
    public partial class UpdateStudentReportTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedEmotion",
                table: "StudentReport");

            migrationBuilder.AddColumn<int>(
                name: "StudentEmotion",
                table: "StudentReport",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentReportReportID",
                table: "Emotion",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentReport_StudentEmotion",
                table: "StudentReport",
                column: "StudentEmotion");

            migrationBuilder.CreateIndex(
                name: "IX_Emotion_StudentReportReportID",
                table: "Emotion",
                column: "StudentReportReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_Emotion_StudentReport_StudentReportReportID",
                table: "Emotion",
                column: "StudentReportReportID",
                principalTable: "StudentReport",
                principalColumn: "ReportID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentReport_Emotion_StudentEmotion",
                table: "StudentReport",
                column: "StudentEmotion",
                principalTable: "Emotion",
                principalColumn: "EmotionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emotion_StudentReport_StudentReportReportID",
                table: "Emotion");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentReport_Emotion_StudentEmotion",
                table: "StudentReport");

            migrationBuilder.DropIndex(
                name: "IX_StudentReport_StudentEmotion",
                table: "StudentReport");

            migrationBuilder.DropIndex(
                name: "IX_Emotion_StudentReportReportID",
                table: "Emotion");

            migrationBuilder.DropColumn(
                name: "StudentEmotion",
                table: "StudentReport");

            migrationBuilder.DropColumn(
                name: "StudentReportReportID",
                table: "Emotion");

            migrationBuilder.AddColumn<string>(
                name: "SelectedEmotion",
                table: "StudentReport",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
