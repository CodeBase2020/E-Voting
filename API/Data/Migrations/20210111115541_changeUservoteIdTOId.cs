using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class changeUservoteIdTOId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserVote_Users_UserVoteId",
                table: "UserVote");

            migrationBuilder.RenameColumn(
                name: "UserVoteId",
                table: "UserVote",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserVote_Users_Id",
                table: "UserVote",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserVote_Users_Id",
                table: "UserVote");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserVote",
                newName: "UserVoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserVote_Users_UserVoteId",
                table: "UserVote",
                column: "UserVoteId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
