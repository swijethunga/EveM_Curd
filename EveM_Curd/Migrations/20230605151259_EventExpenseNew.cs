using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveM_Curd.Migrations
{
    /// <inheritdoc />
    public partial class EventExpenseNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Transac_type",
                table: "EventExpenses",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Transac_type",
                table: "EventExpenses");
        }
    }
}
