using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveM_Curd.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventExpenses",
                columns: table => new
                {
                    Expense_name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Expense_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expense_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventExpenses", x => x.Expense_name);
                });

            migrationBuilder.CreateTable(
                name: "EventIncomes",
                columns: table => new
                {
                    Income_name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Income_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Income_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventIncomes", x => x.Income_name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventExpenses");

            migrationBuilder.DropTable(
                name: "EventIncomes");
        }
    }
}
