using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RaqamliAvlod.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contests",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    is_calculated = table.Column<bool>(type: "boolean", nullable: false),
                    is_public = table.Column<bool>(type: "boolean", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    calculated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tag = table.Column<string>(type: "text", nullable: false),
                    view_count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: false),
                    username = table.Column<string>(type: "text", nullable: true),
                    image_path = table.Column<string>(type: "text", nullable: false),
                    contest_coins = table.Column<int>(type: "integer", nullable: false),
                    problemset_coins = table.Column<int>(type: "integer", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    email_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    password_hash = table.Column<string>(type: "text", nullable: false),
                    salt = table.Column<string>(type: "text", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contest_standings",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    contest_id = table.Column<long>(type: "bigint", nullable: false),
                    result_coins = table.Column<int>(type: "integer", nullable: false),
                    penalty = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contest_standings", x => x.id);
                    table.ForeignKey(
                        name: "FK_contest_standings_contests_contest_id",
                        column: x => x.contest_id,
                        principalTable: "contests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contest_standings_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    info = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    image_path = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    owner_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.id);
                    table.ForeignKey(
                        name: "FK_courses_users_owner_id",
                        column: x => x.owner_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "problemsets",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    input_desciption = table.Column<string>(type: "text", nullable: false),
                    output_desciption = table.Column<string>(type: "text", nullable: false),
                    note = table.Column<string>(type: "text", nullable: false),
                    time_limit = table.Column<int>(type: "integer", nullable: false),
                    memory_limit = table.Column<int>(type: "integer", nullable: false),
                    difficulty = table.Column<short>(type: "smallint", nullable: false),
                    is_public = table.Column<bool>(type: "boolean", nullable: false),
                    contest_coins = table.Column<short>(type: "smallint", nullable: false),
                    contest_identifier = table.Column<char>(type: "character(1)", nullable: false),
                    owner_id = table.Column<long>(type: "bigint", nullable: false),
                    contest_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_problemsets", x => x.id);
                    table.ForeignKey(
                        name: "FK_problemsets_contests_contest_id",
                        column: x => x.contest_id,
                        principalTable: "contests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_problemsets_users_owner_id",
                        column: x => x.owner_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    view_count = table.Column<int>(type: "integer", nullable: false),
                    owner_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.id);
                    table.ForeignKey(
                        name: "FK_questions_users_owner_id",
                        column: x => x.owner_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "course_comments",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    comment_text = table.Column<string>(type: "text", nullable: false),
                    course_id = table.Column<long>(type: "bigint", nullable: false),
                    owner_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_course_comments_courses_course_id",
                        column: x => x.course_id,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_course_comments_users_owner_id",
                        column: x => x.owner_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "course_videos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    youtube_thumb = table.Column<string>(type: "text", nullable: false),
                    view_count = table.Column<int>(type: "integer", nullable: false),
                    youtube_link = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    duration = table.Column<string>(type: "text", nullable: false),
                    course_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_videos", x => x.id);
                    table.ForeignKey(
                        name: "FK_course_videos_courses_course_id",
                        column: x => x.course_id,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contest_standing_details",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    is_fixed = table.Column<bool>(type: "boolean", nullable: false),
                    fixed_time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    penalty_submissions = table.Column<short>(type: "smallint", nullable: false),
                    problemset_id = table.Column<long>(type: "bigint", nullable: false),
                    contest_standing_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contest_standing_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_contest_standing_details_contest_standings_contest_standing~",
                        column: x => x.contest_standing_id,
                        principalTable: "contest_standings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contest_standing_details_problemsets_problemset_id",
                        column: x => x.problemset_id,
                        principalTable: "problemsets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "problemset_tests",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    input = table.Column<string>(type: "text", nullable: false),
                    output = table.Column<string>(type: "text", nullable: false),
                    problemset_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_problemset_tests", x => x.id);
                    table.ForeignKey(
                        name: "FK_problemset_tests_problemsets_problemset_id",
                        column: x => x.problemset_id,
                        principalTable: "problemsets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "submissions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Result = table.Column<string>(type: "text", nullable: false),
                    Language = table.Column<string>(type: "text", nullable: false),
                    ExecutionTime = table.Column<int>(type: "integer", nullable: false),
                    MemoryUsage = table.Column<int>(type: "integer", nullable: false),
                    LengthOfCode = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ProblemSetId = table.Column<long>(type: "bigint", nullable: false),
                    ContestId = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_submissions", x => x.id);
                    table.ForeignKey(
                        name: "FK_submissions_contests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "contests",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_submissions_problemsets_ProblemSetId",
                        column: x => x.ProblemSetId,
                        principalTable: "problemsets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_submissions_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "qestion_answers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false),
                    has_replied = table.Column<bool>(type: "boolean", nullable: false),
                    owner_id = table.Column<long>(type: "bigint", nullable: false),
                    question_id = table.Column<long>(type: "bigint", nullable: false),
                    parent_id = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qestion_answers", x => x.id);
                    table.ForeignKey(
                        name: "FK_qestion_answers_qestion_answers_parent_id",
                        column: x => x.parent_id,
                        principalTable: "qestion_answers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_qestion_answers_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_qestion_answers_users_owner_id",
                        column: x => x.owner_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "question_tags",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    question_id = table.Column<long>(type: "bigint", nullable: false),
                    tag_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_question_tags", x => x.id);
                    table.ForeignKey(
                        name: "FK_question_tags_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_question_tags_tags_tag_id",
                        column: x => x.tag_id,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contest_standing_details_contest_standing_id",
                table: "contest_standing_details",
                column: "contest_standing_id");

            migrationBuilder.CreateIndex(
                name: "IX_contest_standing_details_problemset_id_contest_standing_id",
                table: "contest_standing_details",
                columns: new[] { "problemset_id", "contest_standing_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contest_standings_contest_id",
                table: "contest_standings",
                column: "contest_id");

            migrationBuilder.CreateIndex(
                name: "IX_contest_standings_user_id_contest_id",
                table: "contest_standings",
                columns: new[] { "user_id", "contest_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contests_title",
                table: "contests",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_course_comments_course_id",
                table: "course_comments",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_course_comments_owner_id",
                table: "course_comments",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_course_videos_course_id_youtube_link",
                table: "course_videos",
                columns: new[] { "course_id", "youtube_link" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_courses_owner_id",
                table: "courses",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_problemset_tests_problemset_id",
                table: "problemset_tests",
                column: "problemset_id");

            migrationBuilder.CreateIndex(
                name: "IX_problemsets_contest_id",
                table: "problemsets",
                column: "contest_id");

            migrationBuilder.CreateIndex(
                name: "IX_problemsets_contest_identifier_contest_id",
                table: "problemsets",
                columns: new[] { "contest_identifier", "contest_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_problemsets_name",
                table: "problemsets",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_problemsets_owner_id",
                table: "problemsets",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_qestion_answers_owner_id",
                table: "qestion_answers",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_qestion_answers_parent_id",
                table: "qestion_answers",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_qestion_answers_question_id",
                table: "qestion_answers",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_question_tags_question_id",
                table: "question_tags",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_question_tags_tag_id_question_id",
                table: "question_tags",
                columns: new[] { "tag_id", "question_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_questions_owner_id",
                table: "questions",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_submissions_ContestId",
                table: "submissions",
                column: "ContestId");

            migrationBuilder.CreateIndex(
                name: "IX_submissions_ProblemSetId",
                table: "submissions",
                column: "ProblemSetId");

            migrationBuilder.CreateIndex(
                name: "IX_submissions_UserId",
                table: "submissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tags_tag",
                table: "tags",
                column: "tag",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_email",
                table: "users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_phone_number",
                table: "users",
                column: "phone_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_username",
                table: "users",
                column: "username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contest_standing_details");

            migrationBuilder.DropTable(
                name: "course_comments");

            migrationBuilder.DropTable(
                name: "course_videos");

            migrationBuilder.DropTable(
                name: "problemset_tests");

            migrationBuilder.DropTable(
                name: "qestion_answers");

            migrationBuilder.DropTable(
                name: "question_tags");

            migrationBuilder.DropTable(
                name: "submissions");

            migrationBuilder.DropTable(
                name: "contest_standings");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "problemsets");

            migrationBuilder.DropTable(
                name: "contests");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
