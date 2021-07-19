using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tirkhanti_R12.Migrations
{
    public partial class First_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emotion_AspNetUsers_RespondById",
                table: "Emotion");

            migrationBuilder.RenameColumn(
                name: "RespondById",
                table: "Emotion",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Emotion_RespondById",
                table: "Emotion",
                newName: "IX_Emotion_Id");

            migrationBuilder.AlterColumn<int>(
                name: "StudentEmotion",
                table: "Emotion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AccountCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Emotion_AspNetUsers_Id",
                table: "Emotion",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emotion_AspNetUsers_Id",
                table: "Emotion");

            migrationBuilder.DropColumn(
                name: "AccountCreated",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Emotion",
                newName: "RespondById");

            migrationBuilder.RenameIndex(
                name: "IX_Emotion_Id",
                table: "Emotion",
                newName: "IX_Emotion_RespondById");

            migrationBuilder.AlterColumn<string>(
                name: "StudentEmotion",
                table: "Emotion",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Emotion_AspNetUsers_RespondById",
                table: "Emotion",
                column: "RespondById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
