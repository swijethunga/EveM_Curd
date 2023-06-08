using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveM_Curd.Migrations
{
    /// <inheritdoc />
    public partial class EventDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EventIncomes",
                table: "EventIncomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventExpenses",
                table: "EventExpenses");

            migrationBuilder.AlterColumn<string>(
                name: "Income_name",
                table: "EventIncomes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Income_id",
                table: "EventIncomes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Expense_name",
                table: "EventExpenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Expense_id",
                table: "EventExpenses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventIncomes",
                table: "EventIncomes",
                column: "Income_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventExpenses",
                table: "EventExpenses",
                column: "Expense_id");

            migrationBuilder.CreateTable(
                name: "EventDetails",
                columns: table => new
                {
                    Event_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDetails", x => x.Event_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventIncomes",
                table: "EventIncomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventExpenses",
                table: "EventExpenses");

            migrationBuilder.DropColumn(
                name: "Income_id",
                table: "EventIncomes");

            migrationBuilder.DropColumn(
                name: "Expense_id",
                table: "EventExpenses");

            migrationBuilder.AlterColumn<string>(
                name: "Income_name",
                table: "EventIncomes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Expense_name",
                table: "EventExpenses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventIncomes",
                table: "EventIncomes",
                column: "Income_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventExpenses",
                table: "EventExpenses",
                column: "Expense_name");
        }
    }
}
