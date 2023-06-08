using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveM_Curd.Migrations
{
    /// <inheritdoc />
    public partial class EventCashFlow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventIncomes");

            migrationBuilder.CreateTable(
                name: "EventCashFlows",
                columns: table => new
                {
                    Cex_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cex_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cex_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cex_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cex_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCashFlows", x => x.Cex_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventCashFlows");

            migrationBuilder.CreateTable(
                name: "EventIncomes",
                columns: table => new
                {
                    Income_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Income_amount = table.Column<int>(type: "int", nullable: false),
                    Income_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Income_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventIncomes", x => x.Income_id);
                });
        }
    }
}
