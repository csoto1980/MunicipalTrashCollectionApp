using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70edadb8-fabf-4930-927e-86beb12d9bba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd31775c-723c-4938-95dd-2d986d1be91e");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "accountSuspended",
                table: "Customers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Balance",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "accountSuspended",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70edadb8-fabf-4930-927e-86beb12d9bba", "d8ebacbf-c3d5-4c7a-ac7a-a33dbf43689e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd31775c-723c-4938-95dd-2d986d1be91e", "d3b44d21-9393-4441-8c94-ddf18a56cfbc", "Employee", "EMPLOYEE" });
        }
    }
}
