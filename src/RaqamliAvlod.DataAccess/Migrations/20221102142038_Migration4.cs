using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaqamliAvlod.DataAccess.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseComments_Users_UserId",
                table: "CourseComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_UserId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UserId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseComments_UserId",
                table: "CourseComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CourseComments");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_OwnerId",
                table: "Courses",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseComments_OwnerId",
                table: "CourseComments",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseComments_Users_OwnerId",
                table: "CourseComments",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_OwnerId",
                table: "Courses",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseComments_Users_OwnerId",
                table: "CourseComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_OwnerId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_OwnerId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseComments_OwnerId",
                table: "CourseComments");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Courses",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "CourseComments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserId",
                table: "Courses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseComments_UserId",
                table: "CourseComments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseComments_Users_UserId",
                table: "CourseComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_UserId",
                table: "Courses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
