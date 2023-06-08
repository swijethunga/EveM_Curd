using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveM_Curd.Migrations
{
    /// <inheritdoc />
    public partial class EventForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vendor_Name",
                table: "VendorDetails",
                newName: "Vendor_name");

            migrationBuilder.RenameColumn(
                name: "Service_Offered",
                table: "VendorDetails",
                newName: "Service_offered");

            migrationBuilder.RenameColumn(
                name: "Contact_Person",
                table: "VendorDetails",
                newName: "Contact_person");

            migrationBuilder.RenameColumn(
                name: "Contact_No",
                table: "VendorDetails",
                newName: "Contact_no");

            migrationBuilder.RenameColumn(
                name: "Contact_Email",
                table: "VendorDetails",
                newName: "Contact_email");

            migrationBuilder.RenameColumn(
                name: "Add_Info",
                table: "VendorDetails",
                newName: "Add_info");

            migrationBuilder.RenameColumn(
                name: "Vendor_Id",
                table: "VendorDetails",
                newName: "Vendor_id");

            migrationBuilder.CreateTable(
                name: "EventForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    evTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    evDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mainImgPth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recSinEvnt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    enDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phyOnlEvt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    locations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dcmtPth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cmteMbrs = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventForms", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventForms");

            migrationBuilder.RenameColumn(
                name: "Vendor_name",
                table: "VendorDetails",
                newName: "Vendor_Name");

            migrationBuilder.RenameColumn(
                name: "Service_offered",
                table: "VendorDetails",
                newName: "Service_Offered");

            migrationBuilder.RenameColumn(
                name: "Contact_person",
                table: "VendorDetails",
                newName: "Contact_Person");

            migrationBuilder.RenameColumn(
                name: "Contact_no",
                table: "VendorDetails",
                newName: "Contact_No");

            migrationBuilder.RenameColumn(
                name: "Contact_email",
                table: "VendorDetails",
                newName: "Contact_Email");

            migrationBuilder.RenameColumn(
                name: "Add_info",
                table: "VendorDetails",
                newName: "Add_Info");

            migrationBuilder.RenameColumn(
                name: "Vendor_id",
                table: "VendorDetails",
                newName: "Vendor_Id");
        }
    }
}
