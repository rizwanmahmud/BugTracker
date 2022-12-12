using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Migrations
{
    public partial class removeassignedto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bug_Person_AssignedToId",
                table: "Bug");

            migrationBuilder.DropIndex(
                name: "IX_Bug_AssignedToId",
                table: "Bug");

            migrationBuilder.DropColumn(
                name: "AssignedToId",
                table: "Bug");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedToId",
                table: "Bug",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bug_AssignedToId",
                table: "Bug",
                column: "AssignedToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bug_Person_AssignedToId",
                table: "Bug",
                column: "AssignedToId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
