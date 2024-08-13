using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.Migrations
{
    /// <inheritdoc />
    public partial class createTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department_Tbl",
                columns: table => new
                {
                    DepartmentCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPersonnels = table.Column<int>(type: "int", nullable: false),
                    AdditionalFields = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_Tbl", x => x.DepartmentCode);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Tbl",
                columns: table => new
                {
                    EmployeeCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Tbl", x => x.EmployeeCode);
                    table.ForeignKey(
                        name: "FK_Employee_Tbl_Department_Tbl_DepartmentCode",
                        column: x => x.DepartmentCode,
                        principalTable: "Department_Tbl",
                        principalColumn: "DepartmentCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Tbl_DepartmentCode",
                table: "Employee_Tbl",
                column: "DepartmentCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Tbl");

            migrationBuilder.DropTable(
                name: "Department_Tbl");
        }
    }
}
