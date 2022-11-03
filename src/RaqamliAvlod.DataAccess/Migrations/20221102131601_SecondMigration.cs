using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RaqamliAvlod.DataAccess.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContestSubmissionsInfos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsFixed = table.Column<bool>(type: "boolean", nullable: false),
                    FixedTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    PenaltySubmissions = table.Column<short>(type: "smallint", nullable: false),
                    ProblemSetId = table.Column<long>(type: "bigint", nullable: false),
                    ContestStandingsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestSubmissionsInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContestSubmissionsInfos_ContestStandings_ContestStandingsId",
                        column: x => x.ContestStandingsId,
                        principalTable: "ContestStandings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContestSubmissionsInfos_ProblemSets_ProblemSetId",
                        column: x => x.ProblemSetId,
                        principalTable: "ProblemSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TagName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTags",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuestionId = table.Column<long>(type: "bigint", nullable: false),
                    TagId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionTags_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContestSubmissionsInfos_ContestStandingsId",
                table: "ContestSubmissionsInfos",
                column: "ContestStandingsId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestSubmissionsInfos_ProblemSetId",
                table: "ContestSubmissionsInfos",
                column: "ProblemSetId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTags_QuestionId",
                table: "QuestionTags",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTags_TagId",
                table: "QuestionTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContestSubmissionsInfos");

            migrationBuilder.DropTable(
                name: "QuestionTags");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
