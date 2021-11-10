using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerBlazorEF.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "67dbf75d-cf01-4a58-8cd9-eace603846ad", "Jane", "Smith", "Medicine" },
                    { "debd6ce3-b899-4d7f-b360-c86f2efd4935", "John", "Fisher", "Engineering" },
                    { "e7911e65-8a1d-47cc-a021-012431fb242d", "Pamela", "Baker", "Food Science" },
                    { "7f272dce-e2de-4eb7-8229-ce19ad0056ff", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
