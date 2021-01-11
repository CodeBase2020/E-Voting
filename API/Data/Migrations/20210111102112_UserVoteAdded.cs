using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class UserVoteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserVote",
                columns: table => new
                {
                    UserVoteId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsVoted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVote", x => x.UserVoteId);
                    table.ForeignKey(
                        name: "FK_UserVote_Users_UserVoteId",
                        column: x => x.UserVoteId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserVote");
        }
    }
}
