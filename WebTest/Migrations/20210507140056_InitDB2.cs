using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class InitDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_UsersTable_PersonId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_PersonId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_UsersTable_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "UsersTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_UsersTable_UserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId",
                table: "Messages");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_PersonId",
                table: "Messages",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_UsersTable_PersonId",
                table: "Messages",
                column: "PersonId",
                principalTable: "UsersTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
