using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task7.Migrations
{
    /// <inheritdoc />
    public partial class newInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeacherPupils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    PupilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherPupils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherPupils_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "PupilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherPupils_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Pupils",
                keyColumn: "PupilId",
                keyValue: 1,
                column: "FirstName",
                value: "giorgi");

            migrationBuilder.InsertData(
                table: "TeacherPupils",
                columns: new[] { "Id", "PupilId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                column: "FirstName",
                value: "nika");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherPupils_PupilId",
                table: "TeacherPupils",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherPupils_TeacherId",
                table: "TeacherPupils",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherPupils");

            migrationBuilder.UpdateData(
                table: "Pupils",
                keyColumn: "PupilId",
                keyValue: 1,
                column: "FirstName",
                value: "nika");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                column: "FirstName",
                value: "giorgi");
        }
    }
}
