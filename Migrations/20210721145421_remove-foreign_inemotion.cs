using Microsoft.EntityFrameworkCore.Migrations;

namespace Tirkhanti_R12.Migrations
{
    public partial class removeforeign_inemotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emotion_AspNetUsers_Id",
                table: "Emotion");

            migrationBuilder.DropIndex(
                name: "IX_Emotion_Id",
                table: "Emotion");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Emotion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Emotion",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emotion_Id",
                table: "Emotion",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emotion_AspNetUsers_Id",
                table: "Emotion",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
