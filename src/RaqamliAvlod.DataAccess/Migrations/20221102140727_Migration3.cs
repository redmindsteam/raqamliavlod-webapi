using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaqamliAvlod.DataAccess.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_QuestionAnswers_AnswerId",
                table: "QuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_AnswerId",
                table: "QuestionAnswers");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "QuestionAnswers");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_ParentId",
                table: "QuestionAnswers",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_QuestionAnswers_ParentId",
                table: "QuestionAnswers",
                column: "ParentId",
                principalTable: "QuestionAnswers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_QuestionAnswers_ParentId",
                table: "QuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_ParentId",
                table: "QuestionAnswers");

            migrationBuilder.AddColumn<long>(
                name: "AnswerId",
                table: "QuestionAnswers",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_AnswerId",
                table: "QuestionAnswers",
                column: "AnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_QuestionAnswers_AnswerId",
                table: "QuestionAnswers",
                column: "AnswerId",
                principalTable: "QuestionAnswers",
                principalColumn: "Id");
        }
    }
}
