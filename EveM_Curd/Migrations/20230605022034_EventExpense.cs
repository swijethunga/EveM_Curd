using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveM_Curd.Migrations
{
    /// <inheritdoc />
    public partial class EventExpense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Expense_name",
                table: "EventExpenses",
                newName: "Transac_name");

            migrationBuilder.RenameColumn(
                name: "Expense_date",
                table: "EventExpenses",
                newName: "Transac_date");

            migrationBuilder.RenameColumn(
                name: "Expense_amount",
                table: "EventExpenses",
                newName: "Transac_amount");

            migrationBuilder.RenameColumn(
                name: "Expense_id",
                table: "EventExpenses",
                newName: "Transac_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Transac_name",
                table: "EventExpenses",
                newName: "Expense_name");

            migrationBuilder.RenameColumn(
                name: "Transac_date",
                table: "EventExpenses",
                newName: "Expense_date");

            migrationBuilder.RenameColumn(
                name: "Transac_amount",
                table: "EventExpenses",
                newName: "Expense_amount");

            migrationBuilder.RenameColumn(
                name: "Transac_id",
                table: "EventExpenses",
                newName: "Expense_id");
        }
    }
}
