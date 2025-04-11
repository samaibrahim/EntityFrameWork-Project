using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iti_DB.Migrations
{
    /// <inheritdoc />
    public partial class MigrationV03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Dept_Maneger",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Dept_Maneger",
                table: "Departments",
                column: "Dept_Maneger",
                unique: true,
                filter: "[Dept_Maneger] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Dept_Maneger",
                table: "Departments",
                column: "Dept_Maneger",
                principalTable: "Instructors",
                principalColumn: "Ins_Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Dept_Maneger",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Dept_Maneger",
                table: "Departments");

            migrationBuilder.AlterColumn<string>(
                name: "Dept_Maneger",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
