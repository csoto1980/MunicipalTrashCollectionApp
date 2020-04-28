using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3d3b206-56ee-4e24-8e29-b9dda56d96d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db7ddd48-4d18-416e-817e-ed7b422c6a0c");

            migrationBuilder.DropColumn(
                name: "accountSuspended",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "SuspendAccount",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1b7fe62-54b9-4d19-8bfb-195e3f4db05e", "b5a1f1d1-ee83-479a-afcc-214e6b97266a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85b06d91-ba9e-40b0-b665-ff7de87e6464", "18730255-7139-4bb9-ae29-493e85a5ccd9", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85b06d91-ba9e-40b0-b665-ff7de87e6464");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1b7fe62-54b9-4d19-8bfb-195e3f4db05e");

            migrationBuilder.DropColumn(
                name: "SuspendAccount",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "accountSuspended",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db7ddd48-4d18-416e-817e-ed7b422c6a0c", "9fe07cae-9b82-4e49-a772-6bdc25f844f6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3d3b206-56ee-4e24-8e29-b9dda56d96d7", "43955c9d-7f92-4671-8b15-c10dbda51bb0", "Employee", "EMPLOYEE" });
        }
    }
}
