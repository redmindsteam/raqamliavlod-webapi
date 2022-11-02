using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaqamliAvlod.DataAccess.Migrations
{
    public partial class LastMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProblemSets_Users_UserId",
                table: "ProblemSets");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_Users_UserId",
                table: "QuestionAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Users_UserId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionTags_TagId",
                table: "QuestionTags");

            migrationBuilder.DropIndex(
                name: "IX_Questions_UserId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_UserId",
                table: "QuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_ProblemSets_UserId",
                table: "ProblemSets");

            migrationBuilder.DropIndex(
                name: "IX_CourseVideos_CourseId",
                table: "CourseVideos");

            migrationBuilder.DropIndex(
                name: "IX_ContestSubmissionsInfos_ProblemSetId",
                table: "ContestSubmissionsInfos");

            migrationBuilder.DropIndex(
                name: "IX_ContestStandings_UserId",
                table: "ContestStandings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "QuestionAnswers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProblemSets");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ImagePath",
                table: "Users",
                column: "ImagePath",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Salt",
                table: "Users",
                column: "Salt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_TagName",
                table: "Tags",
                column: "TagName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTags_TagId_QuestionId",
                table: "QuestionTags",
                columns: new[] { "TagId", "QuestionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_OwnerId",
                table: "Questions",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_OwnerId",
                table: "QuestionAnswers",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProblemSets_ContestIdentifier_ContestId",
                table: "ProblemSets",
                columns: new[] { "ContestIdentifier", "ContestId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProblemSets_Name",
                table: "ProblemSets",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProblemSets_OwnerId",
                table: "ProblemSets",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseVideos_CourseId_YouTubeLink",
                table: "CourseVideos",
                columns: new[] { "CourseId", "YouTubeLink" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContestSubmissionsInfos_ProblemSetId_ContestStandingsId",
                table: "ContestSubmissionsInfos",
                columns: new[] { "ProblemSetId", "ContestStandingsId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContestStandings_UserId_ContestId",
                table: "ContestStandings",
                columns: new[] { "UserId", "ContestId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contests_Title",
                table: "Contests",
                column: "Title",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProblemSets_Users_OwnerId",
                table: "ProblemSets",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_Users_OwnerId",
                table: "QuestionAnswers",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Users_OwnerId",
                table: "Questions",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProblemSets_Users_OwnerId",
                table: "ProblemSets");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_Users_OwnerId",
                table: "QuestionAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Users_OwnerId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Users_ImagePath",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Salt",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Tags_TagName",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_QuestionTags_TagId_QuestionId",
                table: "QuestionTags");

            migrationBuilder.DropIndex(
                name: "IX_Questions_OwnerId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_OwnerId",
                table: "QuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_ProblemSets_ContestIdentifier_ContestId",
                table: "ProblemSets");

            migrationBuilder.DropIndex(
                name: "IX_ProblemSets_Name",
                table: "ProblemSets");

            migrationBuilder.DropIndex(
                name: "IX_ProblemSets_OwnerId",
                table: "ProblemSets");

            migrationBuilder.DropIndex(
                name: "IX_CourseVideos_CourseId_YouTubeLink",
                table: "CourseVideos");

            migrationBuilder.DropIndex(
                name: "IX_ContestSubmissionsInfos_ProblemSetId_ContestStandingsId",
                table: "ContestSubmissionsInfos");

            migrationBuilder.DropIndex(
                name: "IX_ContestStandings_UserId_ContestId",
                table: "ContestStandings");

            migrationBuilder.DropIndex(
                name: "IX_Contests_Title",
                table: "Contests");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Questions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "QuestionAnswers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "ProblemSets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTags_TagId",
                table: "QuestionTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_UserId",
                table: "Questions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_UserId",
                table: "QuestionAnswers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProblemSets_UserId",
                table: "ProblemSets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseVideos_CourseId",
                table: "CourseVideos",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestSubmissionsInfos_ProblemSetId",
                table: "ContestSubmissionsInfos",
                column: "ProblemSetId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestStandings_UserId",
                table: "ContestStandings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProblemSets_Users_UserId",
                table: "ProblemSets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_Users_UserId",
                table: "QuestionAnswers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Users_UserId",
                table: "Questions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
