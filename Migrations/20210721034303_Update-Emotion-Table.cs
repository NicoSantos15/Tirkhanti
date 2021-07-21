using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tirkhanti_R12.Migrations
{
    public partial class UpdateEmotionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentReport_Emotion_StudentEmotion",
                table: "StudentReport");

            migrationBuilder.DropIndex(
                name: "IX_StudentReport_StudentEmotion",
                table: "StudentReport");

            migrationBuilder.DropColumn(
                name: "StudentEmotion",
                table: "StudentReport");

            migrationBuilder.AddColumn<string>(
                name: "SelectedEmotion",
                table: "StudentReport",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckedDate",
                table: "LeaderChecked",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AccountCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedEmotion",
                table: "StudentReport");

            migrationBuilder.AddColumn<int>(
                name: "StudentEmotion",
                table: "StudentReport",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckedDate",
                table: "LeaderChecked",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AccountCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentReport_StudentEmotion",
                table: "StudentReport",
                column: "StudentEmotion");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentReport_Emotion_StudentEmotion",
                table: "StudentReport",
                column: "StudentEmotion",
                principalTable: "Emotion",
                principalColumn: "EmotionID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
