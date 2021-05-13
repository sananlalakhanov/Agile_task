using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.DataAccess.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Department",
                columns: table => new
                {
                    DepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Department", x => x.DepId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Employee_tbl_Department_DepId",
                        column: x => x.DepId,
                        principalTable: "tbl_Department",
                        principalColumn: "DepId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Employee_DepId",
                table: "tbl_Employee",
                column: "DepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Employee");

            migrationBuilder.DropTable(
                name: "tbl_Department");
        }
    }
}
