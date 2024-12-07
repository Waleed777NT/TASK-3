using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TASK3.Migrations
{
    /// <inheritdoc />
    public partial class enrollment_grade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gradeid",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_Gradeid",
                table: "Enrollments",
                column: "Gradeid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Grade_Gradeid",
                table: "Enrollments",
                column: "Gradeid",
                principalTable: "Grade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Grade_Gradeid",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_Gradeid",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Gradeid",
                table: "Enrollments");
        }
    }
}
