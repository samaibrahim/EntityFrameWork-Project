using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iti_DB.Migrations
{
    /// <inheritdoc />
    public partial class MigrationV02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "St_super",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_St_super",
                table: "Students",
                column: "St_super");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_St_super",
                table: "Students",
                column: "St_super",
                principalTable: "Students",
                principalColumn: "St_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_St_super",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_St_super",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "St_super",
                table: "Students");
        }
    }
}
